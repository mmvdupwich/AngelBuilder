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
    public partial class WeaponSearch : Form
    {
        public WeaponSearch()
        {
            InitializeComponent();
        }

        private void WeaponSearch_Load(object sender, EventArgs e)
        {

        }

        // This gets exported out;
        public Weapon Weapon_Search_Single { get; set; }

        // Search Input & the Fetcher.
        private string Search_Id { get; set; }
        private void Button_Search_Click(object sender, EventArgs e)
        {
            Search_Id = Text_Search.Text;
            try
            {
                using (var db = new Context())
                {
                    var ws = db.Weapons.Single(w => w.Weapon_Id == Search_Id);

                    Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5} || {6} || {7} || {8}", ws.Weapon_Id, ws.Weapon_Name, ws.Weapon_Points, ws.Weapon_Range, ws.Weapon_Type, ws.Weapon_S, ws.Weapon_Ap, ws.Weapon_Dmg, ws.Weapon_Abi);

                    Weapon_Search_Single = ws;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch 
            { 
                MessageBox.Show("No Such Weapon_Id");
            }
        }

        // Make ENTER execute.
        private void Text_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_Search_Click(this, new EventArgs());
            }
        }
    }
}
