using FacilityServices.DataLayer.Extensions;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacilityServices.DataLayer.Repositories
{
    public class IssueRepository : IIssueRepository
    {
        private FacilityContext facilityContext;

        public IssueRepository(FacilityContext facilityContext)
        {
            this.facilityContext = facilityContext;
        }

        public IssueTO Add(IssueTO Entity)
        {
            if (Entity is null)
                throw new ArgumentNullException(nameof(Entity));

            return facilityContext.Issues
                .Add(Entity.ToEF())
                .Entity
                .ToTransfertObject();
        }

        public IEnumerable<IssueTO> GetAll()
        => facilityContext.Issues
            .Select(x => x.ToTransfertObject())
            .ToList();

        public IssueTO GetByID(int Id)
        {
            return facilityContext.Issues
            .FirstOrDefault(x => x.Id == Id)
            .ToTransfertObject();
        }

        public bool Remove(IssueTO entity)
        => Remove(entity.Id);

        public bool Remove(int Id)
        {
            if (!facilityContext.Issues.Any(x => x.Id == Id))
                throw new Exception($"IssueRepository. Delete(IssueId = {Id}) no record to delete.");

            var ReturnValue = false;

            var issue = facilityContext.Issues.FirstOrDefault(x => x.Id == Id);
            if (issue != default)
            {
                try
                {
                    facilityContext.Issues.Remove(issue);
                    ReturnValue = true;
                }
                catch (Exception)
                {
                    ReturnValue = false;
                }
            }

            return ReturnValue;
        }

        public IssueTO Update(IssueTO Entity)
        {
            if (!facilityContext.Issues.Any(x => x.Id == Entity.Id))
                throw new Exception($"IssueRepository. Update(IssueTransfertObject) no record to update.");

            var attachedIssues = facilityContext.Issues
                .FirstOrDefault(x => x.Id == Entity.Id);

            if (attachedIssues != default)
            {
                attachedIssues.UpdateFromDetached(Entity.ToEF());
            }

            return facilityContext.Issues.Update(attachedIssues).Entity.ToTransfertObject();
        }
    }
}