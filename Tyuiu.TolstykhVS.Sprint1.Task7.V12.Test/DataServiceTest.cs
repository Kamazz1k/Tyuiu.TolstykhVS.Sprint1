using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint1.Task7.V12.Lib;

namespace Tyuiu.TolstykhVS.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
