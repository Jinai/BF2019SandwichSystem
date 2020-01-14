using OnlineServices.Common.FacilityServices.TransfertObjects;
using System;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AssistantRole
    {
        public RoomTO AddRoom(RoomTO room) 
        {
            if (room is null)
            {
                throw new ArgumentNullException(nameof(room));
            }

            return iFSUnitOfWork.RoomRepository.Add(room);
        }
    }
}