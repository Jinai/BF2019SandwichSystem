using OnlineServices.Common.FacilityServices.TransfertObjects;

namespace FacilityServices.BusinessLayer.UseCases
{
    public partial class AssistantRole
    {
        public IssueTO AddIssue(IssueTO issueToAdd)
        {
            if (issueToAdd is null)
            {
                throw new System.ArgumentNullException(nameof(issueToAdd));
            }

            return iFSUnitOfWork.IssueRepository.Add(issueToAdd);
        }
    }
}