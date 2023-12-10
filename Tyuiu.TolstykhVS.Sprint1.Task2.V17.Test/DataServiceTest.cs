using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint1.Task2.V17.Lib;

namespace Tyuiu.TolstykhVS.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 80;
            double res = x / 60;
            Assert.AreEqual(1.2, res);
        }
    }
}
