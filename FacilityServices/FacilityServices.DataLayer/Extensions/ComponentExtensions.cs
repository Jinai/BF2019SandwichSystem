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
        public static ComponentTO ToTransfertObject(this ComponentEF component)
        {
            if (component is null)
                throw new ArgumentNullException(nameof(component));

            return new ComponentTO
            {
                Id = component.Id,
                Room = component.Room.ToTransfertObject(),
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
                Room = component.Room.ToEF(),
                NameEnglish = component.Name.English,
                NameFrench = component.Name.French,
                NameDutch = component.Name.Dutch
            };
        }

        public static ComponentEF UpdateFromDetached(this ComponentEF attachedEF, ComponentEF detachedEF)
        {
            if (attachedEF is null)
                throw new ArgumentNullException(nameof(attachedEF));

            if (detachedEF is null)
                throw new ArgumentNullException(nameof(detachedEF));

            if (attachedEF.Id != detachedEF.Id)
                throw new Exception("Cannot update ComponentEF entity as it is not the same.");

            if ((attachedEF != default) && (detachedEF != default))
            {
                attachedEF.Room = detachedEF.Room;
                attachedEF = attachedEF.FillFromMultiLanguageString(detachedEF.ExtractToMultiLanguageString());
            }

            return attachedEF;
        }
    }
}
