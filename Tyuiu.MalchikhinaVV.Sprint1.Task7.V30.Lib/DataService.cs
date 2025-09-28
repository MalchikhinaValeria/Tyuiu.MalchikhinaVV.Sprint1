using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            

            double result = x + Math.Exp(x) +(Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / Math.Pow(3, x) + Math.Pow(y, 5) / Math.Pow(5, y);
            return Math.Round(result, 3);
        }
    }
}
