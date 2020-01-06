using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

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
