//Домашнее задание. Тема 17. Урок 1. Многомерный
//массив и массив массивов.
//Создать числовой массив одномерных числовых массивов.
//Вручную заполнить его значениями от 1 до 10.
//Взять от пользователя число 200 и присвоить его одному из элементов
//массива.
//Вывести весь массив на консоль

//int[][] number = new int[5][];
//number[0] = new int[5];
//     number[0][0]= 9;
//     number[0][1]= 1;
//     number[0][2]= 7;
//     number[0][3]= 4;
//     number[0][4]= 5;

//number[1] = new int[4];
//     number[1][0] = 8;
//     number[1][1] = 5;
//     number[1][2] = 10;
//     number[1][3] = 6;

//number[2] = new int[7];
//     number[2][0] = 9;
//     number[2][1] = 1;
//     number[2][2] = 7;
//     number[2][3] = 4;
//     number[2][4] = 5;
//     number[2][5] = 5;
//     number[2][6] = 5;

//number[3] = new int[10];
//     number[3][0] = 9;
//     number[3][1] = 1;
//     number[3][2] = 7;
//     number[3][3] = 4;
//     number[3][4] = 5;
//     number[3][5] = 5;
//     number[3][6] = 8;
//     number[3][7] = 5;
//     number[3][8] = 4;
//     number[3][9] = 2;

//number[4] = new int[2];
//     number[4][0] = 1;
//     number[4][1] = 7;


//for (int i = 0; i < number.Length; i++)
//{
//    for (int j = 0; j < number[i].Length; j++)
//    {
//        Console.Write(number[i][j] + " ");


//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Введите число 200:");
//int num1 = int.Parse(Console.ReadLine());

//for (int i = 0; i < number.Length; i++)
//{
//    for (int j = 0; j < number[i].Length; j++)
//    {

//        number[3][9] = num1;
//        Console.Write(number[i][j]  + " ");

//    }
//    Console.WriteLine();
//}
//Домашнее задание. Тема 17. Урок 2. Многомерный
//массив и массив массивов.
//Создайте массив из трех одномерных массивов. [3][ ]
//Заполните его значениями чисел от 1 до 10 (можно вручную, можно
//рандомом)
//Далее добавьте вывод всех значений массива.
//каждый одномерный массив выводится построчно в консоль
//Далее выведите сумму каждого одномерного массива
//*Выведите в конце среднее арифметическое всех значений массива

int[][] mas1 = new int[3][];
mas1[0] = new int[3];
mas1[1] = new int[6];
mas1[2] = new int[8];
int sum = 0;
double sA = 0;

Random random = new Random();
for (int i = 0; i < mas1.Length; i++)
{


    for (int j = 0; j < mas1[i].Length; j++)
    {
        mas1[i][j] = random.Next(1, 10);
        sum = sum + mas1[i][j];

    }

}

for (int i = 0; i < mas1.Length; i++)
{
    int sum1 = 0;

    foreach (int element in mas1[i])
    {
        sum1 += element;
    }

    Console.WriteLine("Сумма элементов массива " + i + ": " + sum1);


    for (int j = 0; j < mas1[i].Length; j++)
    {
        Console.Write(mas1[i][j] + " ");

    }
    Console.WriteLine();
}
foreach (var item in mas1)
{
    double summ = 0;
    foreach (var elen in item)
    {
        summ += elen;
    }
    sA = summ / mas1.Length;
    Console.WriteLine($"Cреднее арифметическое всех значений массива:{sA:F2}");
}

Console.WriteLine($"сумма всех чисел = {sum}");