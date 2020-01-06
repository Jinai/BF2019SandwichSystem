using OnlineServices.Shared.DataAccessHelpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Rooms")]
    public class RoomEF : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string NameFrench { get; set; }
        public string NameEnglish { get; set; }
        public string NameDutch { get; set; }
        public FloorEF FloorAttached { get; set; }
    }
}
