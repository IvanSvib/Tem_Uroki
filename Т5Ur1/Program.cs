


//Console.Write("Введите миллиметры для перевода:");
//double mm = double.Parse(Console.ReadLine());
//double san = mm * 0.1;
//double mil = mm * 1.35*10-7;
//double metr = mm * 0.001;
//double kilom = mm * 0.00001;
//double yard = mm * 0.001094;
//   Console.WriteLine($"{san:F2} см" +
//       $"\n{metr:F2}м." +
//       $"\n{kilom:F2}км." +
//       $"\n{mil:F2}миль." +
//       $"\n{yard:F2}ярдов.");

//Домашнее задание. Тема 13. Урок 2. Циклы while и do
//while.

//1.Написать программу, которая будет генерировать случайные числа от
//1 до 10 и выводить их на экран до тех пор, пока не будет сгенерировано
//число 7.

//Random random = new Random();

//int number = 0;
//do
//{
//    number = random.Next(1, 11);
//    Console.WriteLine($"{number}");
//}
//while (number != 7);

//2.Написать программу, которая будет запрашивать у пользователя
//числа, пока он не введет число 0. После этого программа должна
//вывести сумму всех введенных пользователем чисел

    

double nambe1 = 1;

double summ = 0;

while (nambe1 != 0)
{

    Console.WriteLine("Введите загаданное число!:");
    Random random = new Random();
    nambe1 = random.Next(0, 10);
    Console.WriteLine($"{nambe1}:");
    summ = summ + nambe1;
 

    

} 
Console.WriteLine($"Сумма всех введенных чисел ={summ}:");



















