using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System.Linq;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class ComponentTypeExtensions
    {
        public static ComponentType ToDomain(this ComponentTypeTO ComponentTypeTO)
        {
            return new ComponentType()
            {
                Id = ComponentTypeTO.Id,
                Archived = ComponentTypeTO.Archived,
                Name = ComponentTypeTO.Name,
                Issues = ComponentTypeTO.Issues.Select(x => x.ToDomain()).ToList(),
                
                
                
            };
        }
        public static ComponentTypeTO ToTransfertObject(this ComponentType ComponentType)
        {
            return new ComponentTypeTO()
            {
                Id = ComponentType.Id,
                Archived = ComponentType.Archived,
                Name = ComponentType.Name,
                Issues = ComponentType.Issues.Select(x => x.ToTransfertObject()).ToList(),


            };
        }
    }
}