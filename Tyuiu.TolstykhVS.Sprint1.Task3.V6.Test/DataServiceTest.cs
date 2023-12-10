using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.TolstykhVS.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 67;
            double y = 8.5;
            double z = 6.5;
            double res = x * y / 100 * 2 * 6.5;
            Assert.AreEqual(res,74.035);
        }
    }
}
