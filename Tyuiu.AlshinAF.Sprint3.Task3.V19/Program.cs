﻿using Tyuiu.AlshinAF.Sprint3.Task3.V19.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема:  Оператор цикла foreach                                           *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2 в строке:            *");
Console.WriteLine("* sxxrrg x vfrx                                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string value = "sxxrrg x vfrx";
char chr = 'x';
char chr2 = '2';
Console.WriteLine("Искомая строка = " + value);
Console.WriteLine("Искомый символ = " + chr);
Console.WriteLine("Замена = " + chr2);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Новая строка = " + ds.ReplaceCharOnNum(value, chr, chr2);
Console.ReadKey();