using OnlineServices.Common.FacilityServices.Enumerations;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Common.FacilityServices.Interfaces
{
    public interface IFSAssistantRole : IFSAttendeeRole
    {
        public List<IncidentTO> GetIncidents();
        public CommentTO AddComment(CommentTO comment);
        public ComponentTypeTO AddComponentType(ComponentTypeTO componentTypeToAdd);
        public FloorTO AddFloor(FloorTO floorToAdd);
        public RoomTO AddRoom(RoomTO roomToAdd);
        public IssueTO AddIssue(IssueTO issueToAdd);
        public IncidentTO ChangeIncidentStatus(IncidentStatus statusToSubmit, int incidentId);
    }
}