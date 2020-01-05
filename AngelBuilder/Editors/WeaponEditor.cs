using System;
using System.Linq;
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

        private void WeaponEditor_Load(object sender, EventArgs e)
        {
            this.Weapon_Count();
            Weapon_Array_Build();
        }

        private int Index = -1;
        private Weapon[] Weapons_Array;

        private void Weapon_Array_Build()
        {
            Weapons_Array = new Weapon[Count_Weapons];

            for (int i = 0; i < Count_Weapons; i++)
            {
                Weapons_Array[i] = new Weapon();
            }

            int a = 0;
            using (var db = new Context())
            {
                foreach (var w in db.Weapons)
                {
                    Weapons_Array[a].Weapon_Id = w.Weapon_Id;
                    Weapons_Array[a].Weapon_Name = w.Weapon_Name;
                    Weapons_Array[a].Weapon_Points = w.Weapon_Points;
                    Weapons_Array[a].Weapon_Range = w.Weapon_Range;
                    Weapons_Array[a].Weapon_Type = w.Weapon_Type;
                    Weapons_Array[a].Weapon_S = w.Weapon_S;
                    Weapons_Array[a].Weapon_Ap = w.Weapon_Ap;
                    Weapons_Array[a].Weapon_Dmg = w.Weapon_Dmg;
                    Weapons_Array[a].Weapon_Abi = w.Weapon_Abi;
                    a++;
                }

                foreach (var p in db.Weapons)
                {
                    Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5} || {6} || {7} || {8}", p.Weapon_Id, p.Weapon_Name, p.Weapon_Points, p.Weapon_Range, p.Weapon_Type, p.Weapon_S, p.Weapon_Ap, p.Weapon_Dmg, p.Weapon_Abi);
                }
            }
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
            }
            MessageBox.Show("Saving of Weapon: " + name + " (" + id + ") Successful.");

            Weapon_Count();
            Weapon_Array_Build();
            Weapon_Form_Fill(-1);
        }

        // Various Functions.
        private int Count_Weapons;
        private void Weapon_Count()
        {
            using (var db = new Context())
            {
                Label_Total.Text = db.Weapons.Count().ToString();
                Count_Weapons = db.Weapons.Count();

                if (Count_Weapons == 0)
                {
                    Button_Next.Enabled = false;
                }
                else
                {
                    Button_Next.Enabled = true;
                }
            }            
        }

        private void Weapon_Form_Fill(int Place)
        {
            string Text_Id_Fill;
            string Text_Name_Fill;
            string Text_Points_Fill;
            string Text_Range_Fill;
            string Text_Type_Fill;
            string Text_S_Fill;
            string Text_Ap_Fill;
            string Text_Dmg_Fill;
            string Text_Abi_Fill;

            switch (Place)
            {
                case -1:
                    Text_Id_Fill = "Weapon Id (Unique)";
                    Text_Name_Fill = "Weapon Name";
                    Text_Points_Fill = "Points";
                    Text_Range_Fill = "Range";
                    Text_Type_Fill = "Type";
                    Text_S_Fill = "Strength";
                    Text_Ap_Fill = "AP";
                    Text_Dmg_Fill = "Damage";
                    Text_Abi_Fill = "Ability";
                    break;
                default:
                    Text_Id_Fill = Weapons_Array[Place].Weapon_Id;
                    Text_Name_Fill = Weapons_Array[Place].Weapon_Name;
                    Text_Points_Fill = Weapons_Array[Place].Weapon_Points.ToString();
                    Text_Range_Fill = Weapons_Array[Place].Weapon_Range;
                    Text_Type_Fill = Weapons_Array[Place].Weapon_Type;
                    Text_S_Fill = Weapons_Array[Place].Weapon_S;
                    Text_Ap_Fill = Weapons_Array[Place].Weapon_Ap;
                    Text_Dmg_Fill = Weapons_Array[Place].Weapon_Dmg;
                    Text_Abi_Fill = Weapons_Array[Place].Weapon_Abi;
                    break;
            }            

            Text_Id.Text = Text_Id_Fill;
            Text_Name.Text = Text_Name_Fill;
            Text_Points.Text = Text_Points_Fill;
            Text_Range.Text = Text_Range_Fill;
            Text_Type.Text = Text_Type_Fill;
            Text_Strength.Text = Text_S_Fill;
            Text_Ap.Text = Text_Ap_Fill;
            Text_Dmg.Text = Text_Dmg_Fill;
            Text_Abi.Text = Text_Abi_Fill;
        }

        // Menu Functions.
        private void Button_Next_Click(object sender, EventArgs e)
        {
            Index++;
            // Console.WriteLine("Index: " + Index.ToString());
            Button_Check();          

            Weapon_Form_Fill(Index);

        }

        private void Button_Prev_Click(object sender, EventArgs e)
        {
            Index--;
            // Console.WriteLine("Index: " + Index.ToString());
            Button_Check();

            Weapon_Form_Fill(Index);

        }

        private void Button_Check()
        {
            int Index_Display = Index + 1;
            Label_Amount.Text = Index_Display.ToString();

            if (Index >= Count_Weapons - 1)
            {
                Button_Next.Enabled = false;
            }
            else
            {
                Button_Next.Enabled = true;
            }

            if (Index > 0)
            {
                Button_Prev.Enabled = true;
                Button_Delete.Enabled = true;
            }
            else
            {
                Button_Prev.Enabled = false;
                Button_Delete.Enabled = false;
            }
        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            Index = -1;
            Button_Check();
            Label_Amount.Text = "XXX";
            Weapon_Form_Fill(-1);
        }

        // Search Function Call.
        private void Button_Search_Click(object sender, EventArgs e)
        {
            WeaponSearch search = new WeaponSearch();
            search.Show();
        }
    }
}
