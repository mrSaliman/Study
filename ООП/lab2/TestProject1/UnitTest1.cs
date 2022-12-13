using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Item zhenya = new Item("Zhenya", 23, 1347.248);
            Item dima = new Item("Dima", 17, 248.1347);
            Item result = new Item("Zhenya_Dima", 23 + 17, (1347.248 + 248.1347) / 2);
            Assert.IsTrue(result == (zhenya + dima));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Item zhenya = new Item("Zhenya", 23, 1347.248);
            Item result = new Item("Zhenya", 223, 1347.248);
            Assert.IsTrue(result == (zhenya + 200));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Item dima = new Item("Dima", 17, 248.1347);
            Item result = new Item("Dima", 17, 248.1347 * 5);
            Assert.IsTrue(result == (5 * dima));
        }
    }
}