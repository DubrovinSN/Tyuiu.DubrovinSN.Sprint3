using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DubrovinSN.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19 // (Math.Sin(x) - 2)) + 2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double F;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                   F = Math.Round((((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2), 2);
                   valueArray[count] = F;
                   count++;
            }
            return valueArray;
        }
    }
}
