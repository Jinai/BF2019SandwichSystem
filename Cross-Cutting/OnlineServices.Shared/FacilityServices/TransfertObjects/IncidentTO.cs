using OnlineServices.Shared.FacilityServices.Enumerations;

namespace OnlineServices.Shared.FacilityServices.TransfertObjects
{
    public class IncidentTO
    {
        public int Id { get; set; }
        public ComponentTO Component { get; set; }
        public IssueTO Issue { get; set; }
        public string Comment { get; set; }
        public IncidentStatus Status { get; set; }
    }

}
