using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DubrovinSN.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = "12able 1o s4gh";
            foreach (char chr in value)
            {
                if (Char.IsDigit(chr))
                {
                    str = str.Replace(chr, item);
                }
            }
            return str;
        }
    }
}
