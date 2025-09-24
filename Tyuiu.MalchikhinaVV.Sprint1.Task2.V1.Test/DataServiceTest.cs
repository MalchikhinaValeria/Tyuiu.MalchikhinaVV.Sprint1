using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint1.Task2.V1.Lib;

namespace Tyuiu.MalchikhinaVV.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 50;

            var res = ds.ConvertKmToM(x);

            Assert.AreEqual(31.07520198881293, res);
        }
    }
}
