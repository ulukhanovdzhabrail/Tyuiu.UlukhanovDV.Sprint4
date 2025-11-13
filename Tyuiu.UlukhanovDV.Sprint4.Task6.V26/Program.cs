using Tyuiu.UlukhanovDV.Sprint4.Task6.V26.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных {'Тюмень, 'Тамбов', 'Томск', 'Омск', 'Орёл'}*");
Console.WriteLine("* используя класс Array, выведите элементы                                *");
Console.WriteLine("* массива, длина которых больше 5 символов.                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
var ms = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
Console.WriteLine("Исходный массив:");
for (int i = 0; i <= ms.Length-1; i++)
{
    Console.WriteLine(ms[i]);

}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Элементы массива, длина которых больше 5 символов:");
string[] res = ds.Calculate(ms);
foreach (string s in res)
{
    Console.WriteLine(s);
}
Console.ReadKey();

