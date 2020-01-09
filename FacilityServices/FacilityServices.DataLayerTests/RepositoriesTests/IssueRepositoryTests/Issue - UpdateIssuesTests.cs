using FacilityServices.DataLayer;
using FacilityServices.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.FacilityServices.TransfertObjects;
using OnlineServices.Shared.TranslationServices.TransfertObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FacilityServices.DataLayerTests.RepositoriesTests.IssueRepositoryTests
{
    [TestClass]
    public class UpdateIssuesTests
    {
        [TestMethod()]
        public void UpdateIssueByTransfertObject_Successfull()
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
                var issueRepository = new IssueRepository(memoryCtx);

                var f1 = issueRepository.Add(IssueToUseInTest);
                var f2 = issueRepository.Add(IssueToUseInTest2);
                memoryCtx.SaveChanges();
                f2.Description = "PASProut";
                issueRepository.Update(f2);

                Assert.AreEqual(2, issueRepository.GetAll().Count());
                Assert.AreEqual("PASProut", f2.Description);
            }
        }
    }
}
