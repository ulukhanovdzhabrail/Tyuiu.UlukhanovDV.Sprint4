using Tyuiu.UlukhanovDV.Sprint4.Task3.V7.Lib;
// See https://aka.ms/new-console-template for more information
int[,] array = new int[5, 5] { { 9, 6, 9, 3, 7, }, { 3, 3, 3, 8, 2, }, { 2, 1, 3, 5, 2, }, { 6, 2, 3, 2, 5, }, { 4, 5, 6, 9, 5, } };
int r = array.GetUpperBound(0) + 1;
int c = array.Length / r;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Подсчитайте количество   *");
Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write($"{array[i, j]} \t");

    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine("Сумма нечётных элементов = " + res);
Console.ReadKey();
