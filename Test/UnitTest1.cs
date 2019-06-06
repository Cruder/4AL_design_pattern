using Microsoft.VisualStudio.TestTools.UnitTesting;

using Source;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program();

            Assert.AreEqual(program.Test(), 1);
        }
    }
}
