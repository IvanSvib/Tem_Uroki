
//Домашнее задание. Тема 15. Урок 3. Свойства и методы
//одномерных массивов.
//Напишите программу, которая запрашивает у пользователя 10 целых
//чисел и сохраняет их в массиве. Затем программа сортирует массив по
//возрастанию и выводит отсортированный массив на экран. Далее
//программа запрашивает у пользователя число и находит его индекс в
//массиве. Если число не найдено, программа выводит сообщение об
////ошибке.
Console.WriteLine("Введите 10 чисел!");
int[] mas1 = new int[10];
int[] mas2 = new int[10];

for (int i = 0; i< 10; i++)
{
    Random random = new Random();
    mas1[i] = random.Next(1,100);
    Console.Write(mas1[i] + " ");

    


}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    mas2 = mas1.OrderBy(i => i).ToArray();
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < mas2.Length; i++)
{
    Console.WriteLine(" Введите любое число из указанных выше!");
    int number = int.Parse(Console.ReadLine());
    int rezait = Array.IndexOf(mas2, number);
    Console.WriteLine($"{rezait}"); 
    if (rezait == -1)
        Console.WriteLine("ОШИБКА!");
}


