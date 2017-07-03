using NUnit.Framework;

namespace Testable.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            var c = new Class1();
            Assert.AreEqual(10, c.Dummy(5));
        }
    }
}
