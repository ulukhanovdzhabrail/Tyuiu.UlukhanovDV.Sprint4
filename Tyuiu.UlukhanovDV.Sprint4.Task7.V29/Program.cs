using Tyuiu.UlukhanovDV.Sprint4.Task7.V29.Lib;
// See https://aka.ms/new-console-template for more information
int r = 4;
int c = 3;
int[,] mas = new int[r, c];
string s = "983157642891";
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"983157642891\". Преобразуйте ее     *");
Console.WriteLine("* в матрицу 4 на 3 и подсчитайте сумму четных чисел.                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int index = 0;
Console.WriteLine("\nМассив:");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write($"{s[index]} \t");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(r, c ,s);
Console.WriteLine("Сумма чётных чисел = " + res);
Console.ReadKey();