using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Floor")]
    public class FloorEF
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
