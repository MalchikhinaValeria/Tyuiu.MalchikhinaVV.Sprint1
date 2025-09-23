using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint1.Task1.V3.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.5, res);
        }
    }
}
