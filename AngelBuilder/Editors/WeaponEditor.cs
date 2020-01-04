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
        // OnLoad Stuff.
        public WeaponEditor()
        {
            InitializeComponent();
        }

        private int Index = -1;

        private void WeaponEditor_Load(object sender, EventArgs e)
        {
            this.Weapon_Count();            
        }

        // Saving Functions.
        private void Button_Save_Click(object sender, EventArgs e)
        {
            this.Weapon_Save(Text_Id.Text, Text_Name.Text, Convert.ToInt32(Text_Points.Text), Text_Range.Text, Text_Type.Text, Text_Strength.Text, Text_Ap.Text, Text_Dmg.Text, Text_Abi.Text);
        }

        private void Weapon_Save(string id, string name, int points, string range, string type, string s, string ap, string dmg, string abi)
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

                Weapon_Count();
            }
        }

        // Various Functions.
        private void Weapon_Count()
        {
            using (var db = new Context())
            {
                Label_Total.Text = db.Weapons.Count().ToString();
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            Index++;
            Button_Prev.Enabled = true;
            using (var db = new Context())
            {
                if (Index >= db.Weapons.Count())
                {
                    Button_Next.Enabled = false;                    
                }
            }
        }
        private void Button_Prev_Click(object sender, EventArgs e)
        {
            Index--;
            Button_Next.Enabled = true;
            if (Index <= 0)
            {
                Button_Prev.Enabled = false;
            }            
        }
    }
}
