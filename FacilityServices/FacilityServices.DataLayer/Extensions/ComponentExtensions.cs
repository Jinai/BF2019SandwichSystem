using FacilityServices.DataLayer.Entities;
using OnlineServices.Shared.Extensions;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.DataLayer.Extensions
{
    public static class ComponentExtensions
    {
        public static ComponentTO ToTranfertObject(this ComponentEF component)
        {
            if (component is null)
                throw new ArgumentNullException(nameof(component));

            return new ComponentTO
            {
                Id = component.Id,
                Name = new MultiLanguageString(component.NameEnglish, component.NameFrench, component.NameDutch),
            };
        }

        public static ComponentEF ToEF(this ComponentTO component)
        {
            if (component is null)
                throw new ArgumentNullException(nameof(component));

            return new ComponentEF
            {
                Id = component.Id,
                NameEnglish = component.Name.English,
                NameFrench = component.Name.French,
                NameDutch = component.Name.Dutch
            };
        }

        public static ComponentEF UpdateFromDetached(this ComponentEF AttachedEF, ComponentEF DetachedEF)
        {
            if (AttachedEF is null)
                throw new ArgumentNullException(nameof(AttachedEF));

            if (DetachedEF is null)
                throw new ArgumentNullException(nameof(DetachedEF));

            if (AttachedEF.Id != DetachedEF.Id)
                throw new Exception("Cannot update ComponentEF entity as it is not the same.");

            if ((AttachedEF != default) && (DetachedEF != default))
            {
                AttachedEF.Room = DetachedEF.Room;
                AttachedEF = AttachedEF.FillFromMultiLanguageString(DetachedEF.ExtractToMultiLanguageString());
            }

            return AttachedEF;
        }
    }
}
