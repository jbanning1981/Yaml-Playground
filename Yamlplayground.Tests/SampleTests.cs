using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yamlplayground.Tests
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void AlwaysPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("NotUnit")]
        public void AlwaysFail()
        {
            Assert.IsTrue(false, "This should not show up in CI");
        }
    }
}
