
using System.Threading.Channels;

Console.Write("Введите миллиметры для перевода:");
double mm = double.Parse(Console.ReadLine());
double san = mm * 0.1;
double mil = mm * 1.35*10-7;
double metr = mm * 0.001;
double kilom = mm * 0.00001;
double yard = mm * 0.001094;
   Console.WriteLine($"{san:F2} см" +
       $"\n{metr:F2}м." +
       $"\n{kilom:F2}км." +
       $"\n{mil:F2}миль." +
       $"\n{yard:F2}ярдов.");

