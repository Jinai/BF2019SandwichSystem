using FacilityServices.BusinessLayer.Extensions;
using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole
    {
        public List<RoomTO> GetRoomsByFloor(int floorId)
        {
            if (floorId <= 0)
            {
                throw new LoggedException("The Rooms cannot be reached without existing Floor ID");
            }

            var floor = unitOfWork.FloorRepository.GetById(floorId);
            return unitOfWork.RoomRepository.GetRoomsByFloors(floor);
        }
    }
}