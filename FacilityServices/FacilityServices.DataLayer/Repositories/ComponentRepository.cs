using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class ComponentRepository : IComponentRepository, IRepository<ComponentTo, >
    {
        private FacilityContext facilityContext;

        public ComponentRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}