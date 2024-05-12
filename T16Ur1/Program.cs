//Домашнее задание. Тема 16. Урок 1. Двумерные
//массивы.
//1. Создать двумерный массив 3х3. Заполнить его дробными числами от
//0 до 20.
//Оформить вывод на экран всех чисел.
//Добавить возможность замены значения пользователем.
//Вывод нового массива.
//2. Создать массив символов 5х2.
//Заполнить его символами по желанию в разнобой.
//Вывести на экран понятное слово.
Random random = new Random();
double[,] mas1 = new double[3, 3];
for (int i = 0; i < mas1.GetLength(0); i++)
{



    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = random.NextDouble() * 20;
        Console.Write($"{mas1[i, j]:F2}" + " ");
    }
    Console.WriteLine();

}
int exit = 0;
int m = 0;
do
{ 
    Console.WriteLine(" Если хотите изменить данные - ввдите любое число!" +
    "\nЧтобы выйти из программы введите - 1111");

    exit = int.Parse(Console.ReadLine()!);


if (exit != 1111) { 
    
    Console.Write(" В ведите колво строк в массиве!");
    int naberStrok = int.Parse(Console.ReadLine()!);
    Console.Write(" В ведите колво столбцов в массиве!");
    int naberStolb = int.Parse(Console.ReadLine()!);
    Random ran = new Random();  
    double[,] mas2 = new double[naberStrok, naberStolb];



    for (int i = 0; i < mas2.GetLength(0); i++)
    {



        for (int j = 0; j < mas2.GetLength(1); j++)
        {
            mas2[i, j] = ran.NextDouble() * 20;
            Console.Write($"{mas2[i, j]:F2}" + " ");
        }
        Console.WriteLine();
    }
    
}
else Console.WriteLine("До встречи!!!");
} while (exit!=1111);
