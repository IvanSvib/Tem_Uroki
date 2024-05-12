
//Домашнее задание. Тема 15. Урок 3. Свойства и методы
//одномерных массивов.
//Напишите программу, которая запрашивает у пользователя 10 целых
//чисел и сохраняет их в массиве. Затем программа сортирует массив по
//возрастанию и выводит отсортированный массив на экран. Далее
//программа запрашивает у пользователя число и находит его индекс в
//массиве. Если число не найдено, программа выводит сообщение об
////ошибке.
//Console.WriteLine("Введите 10 чисел!");
//int[] mas1 = new int[10];
//int[] mas2 = new int[10];

//for (int i = 0; i< 10; i++)
//{
//    Random random = new Random();
//    mas1[i] = random.Next(1,100);
//    Console.Write(mas1[i] + " ");




//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2 = mas1.OrderBy(i => i).ToArray();
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();

//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.WriteLine(" Введите любое число из указанных выше!");
//    int number = int.Parse(Console.ReadLine());
//    int rezait = Array.IndexOf(mas2, number);
//    Console.WriteLine($"{rezait}"); 
//    if (rezait == -1)
//        Console.WriteLine("ОШИБКА!");
//}

//Домашнее задание. Тема 15. Урок 4. Свойства и методы
//одномерных массивов. Тип Object.
//Создать 4 массива. Заполнить их случайными числами.
//Конечным результатом должен быть, выведенный на консоль, массив,
//хранящий следующее:
//Произведение средних арифметических (1и2) и (3и4) массивов
//поиндексно.
//Пример:
//1 массив = { 4, 8 };
//2 массив = { 16, 2 };
//ср.ариф. 1 и 2 массивов = { 10, 5 }
//3 массив = { 1, 22 };
//4 массив = { 13, 3 };
//ср.ариф. 3 и 4 массивов = { 7, 12.5 }
//Произведение ср. арифметических:
//ср.ариф. 1 и 2 массивов = { 10, 5 }
//ср.ариф. 3 и 4 массивов = { 7, 12.5 }
//Произведение = { 70, 62.5 }
using static System.Runtime.InteropServices.JavaScript.JSType;


Random random = new Random();
int n = random.Next(5,10);
int[] mas1 = new int[n];
int[] mas2 = new int[n];
int[] mas3 = new int[n];
int[] mas4 = new int[n];
double[] result1 = new double[n];
double[] result2 = new double[n];
double[] result3 = new double[n];
for (int i = 0; i < n; i++)
{
    mas1[i] = random.Next(1, 100);
    mas2[i] = random.Next(1, 100);
    mas3[i] = random.Next(1, 100);
    mas4[i] = random.Next(1, 100);
    result1[i] = (mas1[i] + mas2[i]) / 2.0;
    result2[i] = (mas3[i] + mas4[i]) / 2.0;
    result3[i] = result1[i] * result2[i];
}
Console.Write("1 массив = ");
foreach (double item in mas1)
{
    Console.Write(item + " ");

}
Console.WriteLine();
Console.Write("2 массив = ");
foreach (double item in mas2)
{
    Console.Write(item + " ");

}

Console.WriteLine();
Console.Write("ср.ариф. 1 и 2 массивов = ");
foreach (double item in result1)
{
    Console.Write(item + " ");

}

Console.WriteLine();
Console.Write("3 массив = ");
foreach (double item in mas3)
{
    Console.Write(item + " ");

}
Console.WriteLine();
Console.Write("4 массив = ");
foreach (double item in mas4)
{
    Console.Write(item + " ");

}
Console.WriteLine();
Console.Write("ср.ариф. 3 и 4 массивов = ");
foreach (double item in result2)
{
    Console.Write(item + " ");

}
Console.WriteLine();
Console.Write("Произведение ср. арифметических:");
Console.WriteLine();
Console.Write("ср.ариф. 1 и 2 массивов = ");
foreach (double item in result1)
{
    Console.Write(item + " ");

}
Console.WriteLine();
Console.Write("ср.ариф. 3 и 4 массивов = ");
foreach (double item in result2)
{
    Console.Write(item + " ");

}
Console.WriteLine();
Console.Write("Произведение =  ");
foreach (double item in result3)
{
    Console.Write(item + " ");

}