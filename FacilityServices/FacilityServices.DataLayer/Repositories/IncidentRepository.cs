using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class IncidentRepository : IIncidentRepository
    {
        private FacilityContext facilityContext;

        public IncidentRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}