using System.ComponentModel.DataAnnotations;

namespace AngelBuilder
{
    public class Ability
    {
        [Key]
        public string Ability_Id { get; set; }
        public string Ability_Name { get; set; }
        public string Ability_Text { get; set; }
    }
}
