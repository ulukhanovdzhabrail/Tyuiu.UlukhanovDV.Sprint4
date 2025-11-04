using Tyuiu.UlukhanovDV.Sprint4.Task0.V2.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: *                                                                 *");
Console.WriteLine("* Задание #*                                                              *");
Console.WriteLine("* Вариант #*                                                              *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу                                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
Console.WriteLine("Исходный массив");
for (int i = 0;  i < numsArray.Length; i++)
{
    Console.WriteLine(numsArray[i]);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int sum = ds.GetSumOddArrEl(numsArray);
Console.WriteLine("Сумма нечетных элементов массива = " + sum);
Console.ReadKey();

