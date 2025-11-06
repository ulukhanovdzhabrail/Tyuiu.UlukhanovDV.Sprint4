using Tyuiu.UlukhanovDV.Sprint4.Task2.V12.Lib;
// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму нечетных элементов    *");
Console.WriteLine("* массива.                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];
for (int i = 0; i <= len-1; i++)
{
    numsArray[i] = rnd.Next(4, 9);
}
Console.WriteLine(" Массив:");
for (int i = 0; i < len; i++)
{
    Console.Write(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(numsArray);
Console.WriteLine("Сумма нечётных элементов = " + res);
Console.ReadKey();