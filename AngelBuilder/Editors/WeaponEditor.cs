using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelBuilder
{
    public partial class WeaponEditor : Form
    {
        public WeaponEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weapon_Save(Text_Id.Text, Text_Name.Text, Convert.ToInt32(Text_Points.Text), Text_Range.Text, Text_Type.Text, Text_Strength.Text, Text_Ap.Text, Text_Dmg.Text, Text_Abi.Text);
        }

        void Weapon_Save(string id, string name, int points, string range, string type, string s, string ap, string dmg, string abi)
        {
            using(var db = new Context())
            {
                var weapon = new Weapon() { Weapon_Id = id, Weapon_Name = name, Weapon_Points = points, Weapon_Range = range, Weapon_S = s, Weapon_Ap = ap, Weapon_Type = type, Weapon_Dmg = dmg, Weapon_Abi = abi };
                db.Weapons.Add(weapon);
                db.SaveChanges();

                foreach(var p in db.Weapons)
                {
                    Console.WriteLine("{0}", p.Weapon_Id);
                }
            }
        }

        private void WeaponEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
