
//Домашнее задание. Тема 15. Урок 2. Одномерный
////массив.
//int[] ints = new int[10];
//int rezalt = 0;
//for (int i = 0; i < 10; i++)
//{
//    Random random = new Random();
//    int n = random.Next(1,100);
//    ints[i] =  n ;
//    Console.WriteLine(ints[i]);
//    for (int j = 0; j < ints.Length; j++)
//    {
//        if (ints[i] % 2 == 0)
//        {
//            rezalt++;
//        }
//        break;
//    } 



//}
//Console.WriteLine($" Количество четных чисел = {rezalt}");

//Домашнее задание. Тема 15. Урок 3. Свойства и методы
//одномерных массивов.

//Напишите программу, которая запрашивает у пользователя 10 целых
//чисел и сохраняет их в массиве. Затем программа сортирует массив по
//возрастанию и выводит отсортированный массив на экран. Далее
//программа запрашивает у пользователя число и находит его индекс в
//массиве. Если число не найдено, программа выводит сообщение об
//ошибке.

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Введите 10 чисел!");
int[] mas = new int[10];
int minNum = mas[0];
for (int i = 0; i < 10; i++)
{
    Random random = new Random();
    int number = random.Next(1, 100);
    mas[i] = number;
    Console.WriteLine(mas[i]);
}



for (int i = 1; i < mas.Length; i++)
{
    if (mas[i] < minNum)
    {
        minNum = mas[i];
        Console.WriteLine(minNum);
        
    }


}






