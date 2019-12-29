using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngelBuilder
{
    public class Model
    {
        [Key]
        public string Model_Id { get; set; }
        public string Model_Name { get; set; }
        public int Model_Points { get; set; }

        public string Model_Move { get; set; }
        public string Model_WS { get; set; }
        public string Model_BS { get; set; }
        public string Model_S { get; set; }
        public string Model_T { get; set; }
        public string Model_W { get; set; }
        public string Model_A { get; set; }
        public string Model_Ld { get; set; }
        public string Model_Sv { get; set; }

        public int Model_Min { get; set; }
        public int Model_Max { get; set; }
        public int Model_Def { get; set; }

        public ICollection<Weapon> Model_Weapons { get; set; }
    }
}
