using FacilityServices.BusinessLayer.Extensions;
using OnlineServices.Common.Exceptions;
using OnlineServices.Common.FacilityServices.TransfertObjects;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole
    {
        public List<IssueTO> GetIssuesByComponentType(ComponentTypeTO componentTypeTO)
        {
            if (componentTypeTO is null)
            {
                throw new System.ArgumentNullException(nameof(componentTypeTO));
            }
            if (componentTypeTO.Id <= 0)
            {
                throw new LoggedException("The Issues cannot be reached without existing ComponentType ID");
            }
            return unitOfWork.IssueRepository.GetIssuesByComponentType(componentTypeTO);
        }
    }
}
