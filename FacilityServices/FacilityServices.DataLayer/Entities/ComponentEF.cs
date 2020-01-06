﻿using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Components")]
    public class ComponentEF
    {
        [Key]
        public int Id { get; set; }
        public string NameFrench { get; set; }
        public string NameEnglish { get; set; }
        public string NameDutch { get; set; }
    }
}
