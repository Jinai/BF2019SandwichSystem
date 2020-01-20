using FacilityServices.BusinessLayer.Extensions;
using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole
    {
        public List<ComponentTypeTO> GetComponentTypesByRoom(RoomTO roomTO)
        {
            if (roomTO is null)
            {
                throw new System.ArgumentNullException(nameof(roomTO));
            }
            if (roomTO.Id <= 0)
            {
                throw new LoggedException("The ComponentTypes cannot be reached without existing Room ID");
            }
            return unitOfWork.ComponentTypeRepository.GetComponentTypesByRoom(roomTO);                                                 
        }
    }
}
