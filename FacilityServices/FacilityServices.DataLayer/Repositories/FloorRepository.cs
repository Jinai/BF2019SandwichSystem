using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class FloorRepository : IFloorRepository
    {
        private FacilityContext facilityContext;

        public FloorRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}