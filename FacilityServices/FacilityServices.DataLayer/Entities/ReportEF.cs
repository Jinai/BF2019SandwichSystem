using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Reports")]
    public class ReportEF : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public ComponentEF Component { get; set; }
        public IssueEF Issue { get; set; }
        public RoomEF Room { get; set; }
        public string Comment { get; set; }
        public IncidentStatus Status { get; set; }
    }
}
