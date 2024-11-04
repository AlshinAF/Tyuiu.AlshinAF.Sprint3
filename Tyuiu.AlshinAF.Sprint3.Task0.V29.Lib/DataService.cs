using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AlshinAF.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue) 
        {
            double sumSeries = 0;
            double i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((Math.Pow(value, i*2) + (1/(i+1)))*Math.Cos(value));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
