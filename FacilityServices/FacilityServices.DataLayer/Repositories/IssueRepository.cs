using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class IssueRepository : IIssueRepository
    {
        private FacilityContext facilityContext;

        public IssueRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}