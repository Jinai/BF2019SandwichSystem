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
        public string FrenchName { get; set; }
        public string EnglishName { get; set; }
        public string DeutchName { get; set; }
        public FloorEF FloorAttached { get; set; }
    }
}
