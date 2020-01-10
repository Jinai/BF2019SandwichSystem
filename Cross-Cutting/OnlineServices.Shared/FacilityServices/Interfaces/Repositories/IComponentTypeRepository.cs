using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Shared.FacilityServices.Interfaces.Repositories
{
    public interface IComponentTypeRepository : IRepositoryTemp<ComponentTypeTO, int>
    {
        List<ComponentTypeTO> GetComponentTypesByRoom(RoomTO Room);
    }
}
