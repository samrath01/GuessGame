using GuessGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cylinder cylinder = new Cylinder();
            cylinder.LoadBullet(2);
            Assert.AreEqual(cylinder.Fire(2), true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Cylinder cylinder = new Cylinder();
            cylinder.LoadBullet(2);
            Assert.AreEqual(cylinder.Fire(0), false);
        }
    }
}
