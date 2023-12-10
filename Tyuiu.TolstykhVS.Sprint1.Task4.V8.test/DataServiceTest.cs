using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint1.Task4.V8.Lib;

namespace Tyuiu.TolstykhVS.Sprint1.Task4.V8.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double res = (Math.Sqrt(Math.Abs( x - y)) + 3 * x) / (3 + x);
            Assert.AreEqual(res,1);
        } 
    }
}
    