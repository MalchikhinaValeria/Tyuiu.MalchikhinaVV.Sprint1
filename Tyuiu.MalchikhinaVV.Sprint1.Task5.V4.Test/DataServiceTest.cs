using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int k = 13257;
            int h = ds.SecondsToHours(k);
            int wait = 3;

            Assert.AreEqual(wait, h);
        }
    }
}
