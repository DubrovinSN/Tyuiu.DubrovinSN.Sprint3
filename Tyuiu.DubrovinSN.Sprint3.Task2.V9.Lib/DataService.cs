﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DubrovinSN.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                sumSeries += Math.Pow(1 / Math.Pow(value, startValue), 2);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
