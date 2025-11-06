using Tyuiu.UlukhanovDV.Sprint4.Task4.V7.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 6.                          *");
Console.WriteLine("* Найдите сумму нечетных элементов массива.                               *");
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
        Console.Write($"Введите {i},{j} элемент массива: ");
        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();

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
Console.WriteLine("Сумма нечетных элементов = " +  res);
Console.ReadKey();