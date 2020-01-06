using OnlineServices.Shared.FacilityServices.Enumerations;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class ReportTO
    {
        public int Id { get; set; }
        public ComponentTO Component { get; set; }
        public IssueTO Issue { get; set; }
        public RoomTO Room { get; set; }
        public string Comment { get; set; }
        public ReportStatus Status { get; set; }
    }

}
