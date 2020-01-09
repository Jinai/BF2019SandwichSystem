using OnlineServices.Shared.FacilityServices.Enumerations;
using OnlineServices.Shared.FacilityServices.TransfertObjects;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSAssistantRole : IFSAttendeeRole
    {
        public bool AddComment(CommentTO comment);
        public bool AddComponent(ComponentTO componentToAdd);
        public bool AddComponentType(ComponentTypeTO componentTypeToAdd);
        public bool AddFloor(FloorTO floorToAdd);
        public bool AddRoom(RoomTO roomToAdd);
        public bool AddIssue(IssueTO issueToAdd);
        public bool ChangeIncidentStatus(IncidentStatus statusToSubmit, int incidentId);
    }
}
