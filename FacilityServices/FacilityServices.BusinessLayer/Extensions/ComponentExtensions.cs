using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Shared.FacilityServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class ComponentExtensions
    {
        public static Component ToDomain(this ComponentTO ComponentTO)
        {
            return new Component(ComponentTO.Name)
            {
                Id = ComponentTO.Id
                
            };
        }
        public static ComponentTO ToTransfertObject(this Component Component)
        {
            return new ComponentTO()
            {
                Id = Component.Id,
                Name = Component.Name,
            };
        }
    }
}