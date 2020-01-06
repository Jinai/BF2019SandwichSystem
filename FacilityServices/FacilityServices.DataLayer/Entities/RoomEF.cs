using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Room")]
    public class RoomEF
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public FloorEF FloorAttached { get; set; }
    }
}
