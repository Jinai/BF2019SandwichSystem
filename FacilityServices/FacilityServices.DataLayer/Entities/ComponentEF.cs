using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Components")]
    public class ComponentEF
    {
        [Key]
        public int Id { get; set; }
        public string FrenchName { get; set; }
        public string EnglishName { get; set; }
        public string DeutchName { get; set; }
    }
}
