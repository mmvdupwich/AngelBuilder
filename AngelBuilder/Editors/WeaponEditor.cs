using System;
using System.Linq;
using System.Windows.Forms;

// To do:
// - Extend Search Function to Name.
// - Proper try and catch of the Save function
// - Proper Try and catch of the Intmaker.

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
        private Weapon[] Weapons_Array;
        private string Current_Id = "";

        private void WeaponEditor_Load(object sender, EventArgs e)
        {
            Weapon_Array_Build();

            Weapon_Count();
        }
             
        // The Array Builder, everything passes through here before 
        private void Weapon_Array_Build()
        {
            int a = 0;
            using (var db = new Context())
            {
                Weapons_Array = new Weapon[db.Weapons.Count()];

                for (int i = 0; i < Weapons_Array.Length; i++)
                {
                    Weapons_Array[i] = new Weapon();
                }

                foreach (var w in db.Weapons)
                {
                    Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5} || {6} || {7} || {8}", w.Weapon_Id, w.Weapon_Name, w.Weapon_Points, w.Weapon_Range, w.Weapon_Type, w.Weapon_S, w.Weapon_Ap, w.Weapon_Dmg, w.Weapon_Abi);

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
                                    
            }
        }

        // Saving Functions.
        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Weapon_Save(Current_Id, Text_Name.Text, Convert.ToInt32(Text_Points.Text), Text_Range.Text, Text_Type.Text, Text_Strength.Text, Text_Ap.Text, Text_Dmg.Text, Text_Abi.Text);
            }
            catch
            {
                MessageBox.Show("You entered an invalid Weapon_Id or points value");
            }
        }
        private void Weapon_Save(string id, string name, int points, string range, string type, string s, string ap, string dmg, string abi)
        {
            using(var db = new Context())
            {
                try
                {
                    var check = db.Weapons.Single(w => w.Weapon_Id == id);
                    using (var select = new WeaponUpdater())
                    {
                        select.Label_Id.Text = check.Weapon_Id;
                        select.Label_Name.Text = check.Weapon_Name;

                        var res = select.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            check.Weapon_Id = Text_Id.Text;
                            check.Weapon_Name = Text_Name.Text;
                            check.Weapon_Points = Convert.ToInt32(Text_Points.Text);
                            check.Weapon_Range = Text_Range.Text;
                            check.Weapon_Type = Text_Type.Text;
                            check.Weapon_S = Text_Strength.Text;
                            check.Weapon_Ap = Text_Ap.Text;
                            check.Weapon_Dmg = Text_Dmg.Text;
                            check.Weapon_Abi = Text_Abi.Text;
                            db.SaveChanges();
                            MessageBox.Show("Saving of Weapon: " + name + " (" + id + ") Successful.");
                            Button_New_Click(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Nothing Saved");
                        }
                    }
                }
                catch (InvalidOperationException)
                {
                    var weapon = new Weapon() { Weapon_Id = id, Weapon_Name = name, Weapon_Points = points, Weapon_Range = range, Weapon_S = s, Weapon_Ap = ap, Weapon_Type = type, Weapon_Dmg = dmg, Weapon_Abi = abi };
                    db.Weapons.Add(weapon);
                    db.SaveChanges();
                    MessageBox.Show("Saving of Weapon: " + name + " (" + id + ") Successful.");
                    Button_New_Click(this, new EventArgs());                   
                }                                                                          
            }          
            
        }

        // Various Functions.
        private int Count_Weapons;
        private void Weapon_Count()
        {
            using (var db = new Context())
            {
                Label_Total.Text = Weapons_Array.Length.ToString();
                Count_Weapons = Weapons_Array.Length;

                // Protection against an emty database (and weird negative values).
                if (Count_Weapons <= 0)
                {
                    Button_Next.Enabled = false;
                }
                else
                {
                    Button_Next.Enabled = true;
                }
            }            
        }

        // The Form-Filler. -1 brings in the Defaults of the Fields,
        // any other int will query the Weapons_Array.
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
                    Current_Id = "";
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
                    Current_Id = Weapons_Array[Place].Weapon_Id;
                    //Console.WriteLine("Current Id= " + Current_Id);
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

        // Menu Functions. Next & Previous cycle through Index and filling the Form.
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

        // Checks which Cycle buttons should be active as what time.
        // also the delete button;
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
            }
            else
            {
                Button_Prev.Enabled = false;
            }

            if (Index >= 0)
            {
                Button_Delete.Enabled = true;
            }
            else
            {
                Button_Delete.Enabled = false;
            }
        }

        // New Button: Resets everything to onLoad.
        public void Button_New_Click(object sender, EventArgs e)
        {
            Index = -1;
            Current_Id = "";
            using (var db = new Context())
            {
                Weapons_Array = new Weapon[db.Weapons.Count()];
            }
            Weapon_Array_Build();
            Button_Check();
            Label_Amount.Text = "XXX";
            Weapon_Count();
            Weapon_Form_Fill(Index);
        }

        // Search Function Call. For Now Only Searches for Unique Id's.
        private void Button_Search_Click(object sender, EventArgs e)
        {
            using (var searchform = new WeaponSearch())
            {
                var result = searchform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Weapons_Array = new Weapon[1];
                    Weapons_Array[0] = new Weapon
                    {
                        Weapon_Id = searchform.Weapon_Search_Single.Weapon_Id,
                        Weapon_Name = searchform.Weapon_Search_Single.Weapon_Name,
                        Weapon_Points = searchform.Weapon_Search_Single.Weapon_Points,
                        Weapon_Range = searchform.Weapon_Search_Single.Weapon_Range,
                        Weapon_Type = searchform.Weapon_Search_Single.Weapon_Type,
                        Weapon_S = searchform.Weapon_Search_Single.Weapon_S,
                        Weapon_Ap = searchform.Weapon_Search_Single.Weapon_Ap,
                        Weapon_Dmg = searchform.Weapon_Search_Single.Weapon_Dmg,
                        Weapon_Abi = searchform.Weapon_Search_Single.Weapon_Abi
                    };
                    Index = 0;
                    Weapon_Count();
                    Button_Check();
                    Weapon_Form_Fill(Index);
                }
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            using(var db = new Context())
            {
                var wd = db.Weapons.Single(w => w.Weapon_Id == Current_Id);
                db.Remove(wd);
                db.SaveChanges();
            }
            Button_New_Click(this, new EventArgs());
        }
    }
}
