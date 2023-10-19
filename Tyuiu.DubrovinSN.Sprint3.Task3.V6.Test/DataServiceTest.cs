using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint3.Task3.V6.Lib;

namespace Tyuiu.DubrovinSN.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceNumOnChard1()
        {
            DataService ds = new DataService();
            string str = "12able 1o s4gh";
            char chr = 't';
            string res = ds.ReplaceNumOnChar(str, chr);
            Assert.AreEqual("ttable to stgh", res);

        }
    }
}
