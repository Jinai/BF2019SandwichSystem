using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Shared.FacilityServices.Interfaces
{
    public interface IFSAssistantRole
    {
        public bool AddCommentToReport();

        public List<ReportTO> GetReportList();
        public bool AcceptReport();

        public bool RefuseReport();
        

    }
}
