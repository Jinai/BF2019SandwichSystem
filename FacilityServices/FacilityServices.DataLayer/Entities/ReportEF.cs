using OnlineServices.Shared.FacilityServices.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityServices.DataLayer.Entities
{
    [Table("Report")]
    public class ReportEF
    {
        [Key]
        public int Id { get; set; }
        public ComponentEF Component { get; set; }
        public IssueEF Issue { get; set; }
        public RoomEF Room { get; set; }
        public string Comment { get; set; }
        public ReportStatus Status { get; set; }
    }
}
