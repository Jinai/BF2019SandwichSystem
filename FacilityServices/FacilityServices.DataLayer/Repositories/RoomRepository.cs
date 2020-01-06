using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;

namespace FacilityServices.DataLayer.Repositories
{
    internal class RoomRepository : IRoomRepository
    {
        private FacilityContext facilityContext;

        public RoomRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }
    }
}