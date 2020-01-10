using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Shared.FacilityServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class FloorExtensions
    {
        public static Floor ToDomain(this FloorTO FloorTO)
        {
            return new Floor(FloorTO.Number)
            {
                Id = FloorTO.Id
            };
        }
        public static FloorTO ToTransfertObject(this Floor Floor)
        {
            return new FloorTO()
            {
                Id = Floor.Id,
                Number = Floor.Number,
            };
        }
    }
}
