﻿using Tyuiu.AlshinAF.Sprint3.Task6.V20.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема:  Операции сравнения                                               *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
Console.WriteLine("* числовому отрезку [20, 32] количество всех делителей меньше 12          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int start = 20;
int stop = 32;
Console.WriteLine("Начало отрезка = " + start);
Console.WriteLine("Конец отрезка = " + stop);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество = " + ds.GetSumTheDivisors(start, stop));
Console.ReadKey();