using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSAttendeeRole
    {
        public bool CreateReport();
        public List<ReportTO> GetReportList();
        public List<IssueTO> GetBreakTypeList();
        public List<FloorTO> GetFloorList();
        public List<RoomTO> GetRoomList();
    }
}
