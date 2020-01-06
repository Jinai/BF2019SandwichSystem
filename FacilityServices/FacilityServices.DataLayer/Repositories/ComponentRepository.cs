using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class ComponentRepository : IComponentRepository
    {
        private FacilityContext facilityContext;

        public ComponentRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}