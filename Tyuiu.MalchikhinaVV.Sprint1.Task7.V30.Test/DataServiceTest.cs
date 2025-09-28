using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint1.Task7.V30.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 11.627;
            double res = ds.Calculate(x,y);

            Assert.AreEqual(wait, res);
        }
    }
}
