using OnlineServices.Shared.DataAccessHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Floors")]
    public class FloorEF : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string FrenchName { get; set; }
        public string EnglishName { get; set; }
        public string DeutchName { get; set; }
    }
}
