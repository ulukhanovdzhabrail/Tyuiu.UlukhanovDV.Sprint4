using Tyuiu.UlukhanovDV.Sprint4.Task5.V19.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Random rand = new Random();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -2 до 3.                           *");
Console.WriteLine("* Найти количество положительных элементов.                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите количество строк в массиве: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] mtrx = new int[r, c];
Console.WriteLine("***************************************************************************");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        mtrx[i, j] = rand.Next(-2, 3);

    }
}
Console.WriteLine("\nМассив:");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");

    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(mtrx);
Console.WriteLine("Количество положительных элементов = " + res);
Console.ReadKey();