//Домашнее задание. Тема 13. Урок 1. Циклы while и do
//while.

Console.WriteLine("Отгадайте число, которое загодал компьютер от 1 до 5.");
int men = 0;
int comp = 0;
int count = 0;
do 
{
    Random random = new Random();
    int n = random.Next(1, 5);
    int m = int.Parse(Console.ReadLine());

    if (m == n)
    {
        Console.WriteLine("ПОБЕДА");
        ++men;
    }
    else if (m > 5)
        {

        Console.WriteLine($"Вы играете не по правилам!!!");
        ++comp;
    }
    else if (m != n)
    {
          Console.WriteLine($" Число было {n}");
        ++comp;
        
    }
        count++;
}
while (count<3);
if (men > comp)
{
    Console.WriteLine($"Вы победили {men}/{comp} -Победа");
}
else if (men < comp)
{
    Console.WriteLine($"Победил компьютер {men}/{comp} -Поражение");
}







