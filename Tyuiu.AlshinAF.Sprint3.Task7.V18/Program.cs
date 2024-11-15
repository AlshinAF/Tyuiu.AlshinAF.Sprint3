using Tyuiu.AlshinAF.Sprint3.Task7.V18.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
Console.WriteLine("* F(x) = (2*x-3)/(cos(x)+x) + 5                                           *");
Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*");
Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
Console.WriteLine("* значение 0. Значения округлить до двух знаков после запятой.            *");
Console.WriteLine("* Значения занести в массив!                                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int start = -5;
int stop = 5;
Console.WriteLine("Старт шага = " + start);
Console.WriteLine("Конец шага = " + stop);
int len = ds.GetMassFunction(start, stop).Length;
double[] vallueArray;
vallueArray = new double[len];
vallueArray = ds.GetMassFunction(start, stop);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*+----------+----------+*");
Console.WriteLine("*|     X    |     F(x) |*");
Console.WriteLine("*+----------+----------+*");
for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0,5:d}      |  {1, 5:f2}   |", start, vallueArray[i]);
    start++;
}
Console.WriteLine("*+----------+----------+*");
Console.ReadKey();