using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Component")]
    public class ComponentEF
    {
        [Key]
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
    }
}
