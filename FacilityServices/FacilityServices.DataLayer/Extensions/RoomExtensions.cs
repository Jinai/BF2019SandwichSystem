using FacilityServices.BusinessLayer;
using FacilityServices.DataLayer.Entities;
using OnlineServices.Shared.Extensions;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacilityServices.DataLayer.Extensions
{
    public static class RoomExtensions
    {
        public static RoomTO ToTransfertObject(this RoomEF Room)
        {
            if (Room is null)
                throw new ArgumentNullException(nameof(Room));

            return new RoomTO
            {
                Id = Room.Id,
                Floor = Room.Floor.ToTransfertObject(),
                Name = new MultiLanguageString(Room.NameEnglish, Room.NameFrench, Room.NameDutch),
                Archived = Room.Archived,
                ComponentTypes = Room.RoomComponents?.Select(x => x.ComponentType.ToTransfertObject()).ToList(),
                
            };
        }

        public static RoomEF ToEF(this RoomTO Room)
        {
            if (Room is null)
                throw new ArgumentNullException(nameof(Room));

            return new RoomEF()
            {
                Id = Room.Id,
                Floor = Room.Floor.ToEF(),
                NameEnglish = Room.Name.English,
                NameFrench = Room.Name.French,
                NameDutch = Room.Name.Dutch,
                Archived = Room.Archived,
                // TODO Extension methods RoomComponents                         RoomComponents = Room.ComponentTypes?.Select(x => x.RoomComponents.ToEF()).ToList(),

            };
        }
        public static RoomEF UpdateFromDetached(this RoomEF AttachedEF, RoomEF DetachedEF)
        {
            if (AttachedEF is null)
                throw new ArgumentNullException(nameof(AttachedEF));

            if (DetachedEF is null)
                throw new ArgumentNullException(nameof(DetachedEF));

            if (AttachedEF.Id != DetachedEF.Id)
                throw new Exception("Cannot update ComponentEF entity as it is not the same.");

            if ((AttachedEF != default) && (DetachedEF != default))
            {
                AttachedEF.Floor = DetachedEF.Floor;
                AttachedEF = AttachedEF.FillFromMultiLanguageString(DetachedEF.ExtractToMultiLanguageString());
                AttachedEF.Archived = DetachedEF.Archived;
            }

            return AttachedEF;
        }
    }
}
