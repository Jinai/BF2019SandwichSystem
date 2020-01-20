using FacilityServices.BusinessLayer.Extensions;
using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole
    {
        public List<RoomTO> GetRoomsByFloor(FloorTO floorTO)
        {
            if (floorTO is null)
            {
                throw new System.ArgumentNullException(nameof(floorTO));
            }
            if (floorTO.Id <= 0)
            {
                throw new LoggedException("The Rooms cannot be reached without existing Floor ID");
            }
            
            return unitOfWork.RoomRepository.GetRoomsByFloors(floorTO);
        }
    }
}