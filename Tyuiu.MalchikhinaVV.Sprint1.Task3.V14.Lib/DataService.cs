using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            
            double a = number % 10;
            double b = Math.Floor(number / 10) % 10;
            double c = Math.Floor(number / 100);

            number = a * 100 + b * 10 + c;

            return Math.Round(number, 3);
        }
    }
}
