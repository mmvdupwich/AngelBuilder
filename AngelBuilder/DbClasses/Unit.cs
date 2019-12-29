using System.ComponentModel.DataAnnotations;

namespace AngelBuilder
{
    public class Unit
    {
        [Key]
        public string Unit_Id { get; set; }
        public string Unit_Name { get; set; }
        public int Unit_Cat { get; set; }

        public int Unit_Min { get; set; }
        public int Unit_Max { get; set; }

        //public bool Unit_FW { get; set; }
    }
}
