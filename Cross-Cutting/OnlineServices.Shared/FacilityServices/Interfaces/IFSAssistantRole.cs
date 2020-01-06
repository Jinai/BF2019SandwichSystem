using OnlineServices.Shared.FacilityServices.Enumerations;
using OnlineServices.Shared.FacilityServices.TransfertObjects;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSAssistantRole : IFSAttendeeRole
    {
        public bool AddCommentToReport(string commentToAdd, int reportId);
        public bool AddComponent(ComponentTO componentToAdd);
        public bool AddFloor(FloorTO floorToAdd);
        public bool AddRoom(RoomTO roomToAdd);
        public bool AddIssue(IssueTO issueToAdd);
        public bool ChangeReportStatus(ReportStatus statusToSubmit, int reportId);

    }
}
