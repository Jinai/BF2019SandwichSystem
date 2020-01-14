using OnlineServices.Common.FacilityServices.Interfaces;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole : IFSAttendeeRole
    {
        private readonly IFSUnitOfWork iMSUnitOfWork;
        private IFSUnitOfWork iFSUnitOfWork;

        public AttendeeRole(IFSUnitOfWork iFSUnitOfWork)
        {
            this.iFSUnitOfWork = iFSUnitOfWork ?? throw new ArgumentNullException(nameof(iFSUnitOfWork));
        }

    }
}
