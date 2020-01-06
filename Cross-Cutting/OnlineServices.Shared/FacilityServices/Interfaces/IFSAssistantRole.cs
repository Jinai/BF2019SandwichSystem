using OnlineServices.Shared.FacilityServices.Enumerations;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSAssistantRole : IFSAttendeeRole
    {
        public bool AddCommentToReport(string CommentToAdd, int ReportId);
        public bool AddComponent(ComponentTO ComponentToAdd);
        public bool AddFloor(FloorTO FloorToAdd);
        public bool AddRoom(RoomTO RoomToAdd);
        public bool AddIssue (IssueTO IssueToAdd);
        public List<ReportTO> GetReportList();
        public bool ChangeReportStatus(ReportStatus StatusToSubmit, int ReportId);

    }
}
