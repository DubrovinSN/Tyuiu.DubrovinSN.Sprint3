using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint3.Task2.V9.Lib;

namespace Tyuiu.DubrovinSN.Sprint3.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.125, res);
        }
    }
}
