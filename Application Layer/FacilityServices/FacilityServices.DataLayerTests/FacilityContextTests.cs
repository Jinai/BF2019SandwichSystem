using FacilityServices.DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacilityServices.DataLayerTests
{
    [TestClass]
    public class FacilityContextTests
    {
        [TestMethod]
        public void DefaultCTOR_Successful()
        {
            var context = new FacilityContext();
            Assert.IsNotNull(context);
        }
    }
}
