using System.ComponentModel.DataAnnotations;

namespace AngelBuilder
{
    public class Weapon
    {
        [Key]
        public string Weapon_Id { get; set; }
        public string Weapon_Name { get; set; }
        public int Weapon_Points { get; set; }
        public string Weapon_Range { get; set; }
        public string Weapon_Type { get; set; }
        public string Weapon_S { get; set; }
        public string Weapon_Ap { get; set; }
        public string Weapon_Dmg { get; set; }
        public string Weapon_Abi { get; set; }
    }
}
