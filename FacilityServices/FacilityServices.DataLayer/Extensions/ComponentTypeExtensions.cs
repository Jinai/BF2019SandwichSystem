using FacilityServices.DataLayer.Entities;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Linq;

namespace FacilityServices.DataLayer.Extensions
{
    public static class ComponentTypeExtensions
    {
        public static ComponentTypeTO ToTransfertObject(this ComponentTypeEF componentType)
        {
            if (componentType is null)
                throw new ArgumentNullException(nameof(componentType));

            return new ComponentTypeTO
            {
                Id = componentType.Id,
                Name = new MultiLanguageString(componentType.NameEnglish, componentType.NameFrench, componentType.NameDutch),
                Archived = componentType.Archived,
                Issues = componentType.Issues.Select(x => x.ToTransfertObject()).ToList(),
            };
        }

        public static ComponentTypeEF ToEF(this ComponentTypeTO componentType)
        {
            if (componentType is null)
                throw new ArgumentNullException(nameof(componentType));

            return new ComponentTypeEF
            {
                Id = componentType.Id,
                NameEnglish = componentType.Name.English,
                NameFrench = componentType.Name.French,
                NameDutch = componentType.Name.Dutch,
                Archived = componentType.Archived,
                Issues = componentType.Issues.Select(x => x.ToEF()).ToList(),
                
            };
        }
    }
}
