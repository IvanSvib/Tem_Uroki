
//Домашнее задание. Тема 15. Урок 2. Одномерный
//массив.
int[] ints = new int[10];
int rezalt = 0;
for (int i = 0; i < 10; i++)
{
    Random random = new Random();
    int n = random.Next(1,100);
    ints[i] =  n ;
    Console.WriteLine(ints[i]);
    for (int j = 0; j < ints.Length; j++)
    {
        if (ints[i] % 2 == 0)
        {
            rezalt++;
        }
        break;
    } 
     


}
Console.WriteLine($" Количество четных чисел = {rezalt}");



