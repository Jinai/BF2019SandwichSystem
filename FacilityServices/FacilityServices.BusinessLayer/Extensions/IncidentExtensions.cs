using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Shared.FacilityServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class IncidentExtensions
    {
        public static Incident ToDomain(this IncidentTO IncidentTO)
        {
            return new Incident
            {
                Id = IncidentTO.Id,
                Issue = IncidentTO.Issue.ToDomain(),
                //Comment = IncidentTO.Comment,
                Status = IncidentTO.Status,
                SubmitDate = IncidentTO.SubmitDate

            };
        }

        public static IncidentTO ToTransfertObject(this Incident Incident)
        {
            return new IncidentTO
            {
                Id = Incident.Id,
                Issue = Incident.Issue.ToTransfertObject(),
                //Comment = Incident.Comment,
                Status = Incident.Status,
                SubmitDate = Incident.SubmitDate
            };
        }
    }
}
