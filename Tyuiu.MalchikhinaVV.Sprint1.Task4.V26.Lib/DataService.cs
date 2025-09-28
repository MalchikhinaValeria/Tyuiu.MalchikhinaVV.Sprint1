using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            double result = (Math.Atan(x) - y) / (Math.Exp(x) * (4 / Math.PI));
            return Math.Round(result,3);
        }
    }
}
