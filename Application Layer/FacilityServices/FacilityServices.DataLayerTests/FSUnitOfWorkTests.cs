using FacilityServices.DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.DataLayerTests
{
    [TestClass]
    public class FSUnitOfWorkTests
    {
        [TestMethod]
        public void CTOR_ThrowException_WhenNullIsSupplied()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FSUnitOfWork(null));
        }
    }
}
