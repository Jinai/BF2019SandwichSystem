using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Issues")]
    public class IssueEF : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
    }
}
