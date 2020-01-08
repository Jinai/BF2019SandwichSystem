using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Linq;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.IssueRepositoryTests
{
    [TestClass]
    public class AddIssuesTests
    {
        [TestMethod()]
        public void AddIssues_ThrowsException_WhenANonExistingIdIsProvided()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                var IssueToUseInTest = new IssueTO
                {
                    Description = "prout",
                    Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL")
                };

                var issueRepository = new IssueRepository(memoryCtx);

                Assert.ThrowsException<ArgumentNullException>(() => issueRepository.Add(null));

            }
        }
        [TestMethod()]
        public void AddIssue_Successfull()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                var IssueToUseInTest = new IssueTO
                {
                    Description = "prout",
                    Name = new MultiLanguageString("Issue1EN", "Issue1FR", "Issue1NL")
                };

                var issueRepository = new IssueRepository(memoryCtx);

                issueRepository.Add(IssueToUseInTest);
                memoryCtx.SaveChanges();

                Assert.AreEqual(1, issueRepository.GetAll().Count());
                var IssueToAssert = issueRepository.GetByID(1);
                Assert.AreEqual(1, IssueToAssert.Id);
                Assert.AreEqual("prout", IssueToAssert.Description);
            }
        }
    }
}
