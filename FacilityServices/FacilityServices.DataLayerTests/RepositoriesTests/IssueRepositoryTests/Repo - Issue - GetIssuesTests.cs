using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineServices.Shared.FacilityServices.Exceptions;
using OnlineServices.Shared.FacilityServices.Interfaces.Repositories;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Linq;
using System.Reflection;

namespace FacilityServices.DataLayerTests.RepositoriesTests.IssueRepositoryTests
{
    [TestClass]
    public class GetIssuesTests
    {
        [TestMethod()]
        public void GetIssueById_ThrowsException_WhenInvalidIdIsProvided()
        {
            var options = new DbContextOptionsBuilder<FacilityContext>()
                .UseInMemoryDatabase(databaseName: MethodBase.GetCurrentMethod().Name)
                .Options;
            using (var memoryCtx = new FacilityContext(options))
            {
                var issueRepository = new IssueRepository(memoryCtx);

                Assert.ThrowsException<NotExistingIssueException>(() => issueRepository.GetByID(84));
            }
        }
        [TestMethod()]
        public void GetIssueById_Successfull()
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

                var IssueToAssert = issueRepository.GetByID(1);
                Assert.AreEqual(1, IssueToAssert.Id);
                Assert.AreEqual("prout", IssueToAssert.Description);
            }
        }

        [TestMethod()]
        public void GetAllIssues_Successfull()
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

                var IssueToUseInTest2 = new IssueTO
                {
                    Description = "proutprout",
                    Name = new MultiLanguageString("Issue2EN", "Issue2FR", "Issue2NL")
                };
                var IssueToUseInTest3 = new IssueTO
                {
                    Description = "proutproutprout",
                    Name = new MultiLanguageString("Issue3EN", "Issue3FR", "Issue3NL")
                };
                var issueRepository = new IssueRepository(memoryCtx);

                issueRepository.Add(IssueToUseInTest);
                issueRepository.Add(IssueToUseInTest2);
                issueRepository.Add(IssueToUseInTest3);
                memoryCtx.SaveChanges();

                Assert.AreEqual(3, issueRepository.GetAll().Count());
            }
        }
    }
}
