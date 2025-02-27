﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AlshinAF.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries = SumSeries + (Math.Cos(startValue)*0.5);
                startValue++;

            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
