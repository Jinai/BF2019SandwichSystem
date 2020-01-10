using OnlineServices.Shared.DataAccessHelpers;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.Interfaces.Repositories
{
    public interface IComponentRepository : IRepositoryTemp<ComponentTO, int>
    {
        // TODO : GetComponentsByRoom()
        List<ComponentTO> GetComponentByRoom(RoomTO Room);

    }
}
