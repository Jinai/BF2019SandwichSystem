using FacilityServices.BusinessLayer.Domain;
using OnlineServices.Common.FacilityServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.Extensions
{
    public static class IssueExtensions
    {
        public static Issue ToDomain(this IssueTO IssueTO)
        {
            return new Issue(IssueTO.Name)
            {
                Id = IssueTO.Id,
                Description = IssueTO.Description
            };
        }
        public static IssueTO ToTransfertObject(this Issue Issue)
        {
            return new IssueTO()
            {
                Id = Issue.Id,
                Name = Issue.Name,
                Description = Issue.Description
            };
        }
    }
}
