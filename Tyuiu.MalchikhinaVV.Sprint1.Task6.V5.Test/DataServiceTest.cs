using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint1.Task6.V5.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidText()
        {
            DataService ds = new DataService();
            string str = "казак тоже идет в шалаш";
            var res = ds.CheckSymmetricalWords(str);
            string wait = "казак шалаш";

            Assert.AreEqual(wait, res);
        }
    }
}
