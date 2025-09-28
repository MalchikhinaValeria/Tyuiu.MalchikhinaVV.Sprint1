using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalchikhinaVV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {

            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '\t', '\n', '\r' };

            string res = string.Join(" ", value.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length > 1) 
                .Where(x => x.ToLower() == new string(x.ToLower().Reverse().ToArray())));

            return res;
        }
    }
    
}
