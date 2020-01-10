using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSAttendeeRole
    {
        public bool CreateIncident(IncidentTO incidentTO);
        public List<IncidentTO> GetIncidents(int userId);
        public List<IssueTO> GetIssues();
        public List<FloorTO> GetFloors();
        public List<RoomTO> GetRooms();
        public List<ComponentTypeTO> GetComponents();
        public List<ComponentTypeTO> GetComponentTypes();
    }
}
