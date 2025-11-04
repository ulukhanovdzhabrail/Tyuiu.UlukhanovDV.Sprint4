using Tyuiu.UlukhanovDV.Sprint4.Task1.V8.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму нечетных *");
Console.WriteLine("* элементов массива. С клавиатуры: 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];
for (int i = 0; i < len; i++)
{
    Console.Write("Введите значение " + i + " элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine(" Массив:");
for (int i = 0; i < len; i++)
{
    Console.Write(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.Calculate(numsArray));
Console.ReadKey();