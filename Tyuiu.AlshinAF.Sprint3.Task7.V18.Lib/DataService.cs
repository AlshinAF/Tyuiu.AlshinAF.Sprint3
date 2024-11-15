using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AlshinAF.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len]; //создаём массив с указанной длиной
            double y;
            int count = 0; //индекс массива
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) + x) == 0)
                {
                    y = 0;
                    valueArray[count] = y; //присваиваем значение в массив с индексом count
                    count++;
                }
                else
                {
                    y = Math.Round((2 * x - 3) / (Math.Cos(x) + x) + 5, 2);
                    valueArray[count] = y; //присваиваем значение в массив с индексом count
                    count++;
                }    
            }
            return valueArray;
        }
    }
}
