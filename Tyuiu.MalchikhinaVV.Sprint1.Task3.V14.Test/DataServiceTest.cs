using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint1.Task3.V14.Lib;

namespace Tyuiu.MalchikhinaVV.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidateExpression()
        {
            DataService ds = new DataService();
            double x = 123;
            double wait = 321.000;
            var res = ds.ReverseNumber(x);

            Assert.AreEqual(wait, res);

        }
    }
}
