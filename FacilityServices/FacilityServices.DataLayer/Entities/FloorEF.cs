using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.TranslationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Floors")]
    public class FloorEF : IEntity<int>, IMultiLanguageNameFields
    {
        [Key]
        public int Id { get; set; }
        public string NameFrench { get; set; }
        public string NameEnglish { get; set; }
        public string NameDutch { get; set; }
    }
}
