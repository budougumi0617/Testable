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

        [Test]
        public void TestSample()
        {
            Assert.AreEqual(10, Class1.Sample());
        }
    }
}
