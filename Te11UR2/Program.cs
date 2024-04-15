
//Домашнее задание. Тема 11. Урок 3. Условные операторы
//и класс Random.


Console.WriteLine("Введите число от 0 до 5. ");
int x = int.Parse(Console.ReadLine());
Random random = new Random();
int y= random.Next(0,5);
Console.WriteLine($"{y}");
switch (x)
{
    case 1:
        {
            if (y == x )Console.WriteLine("victory");
           else Console.WriteLine("defeat");

        }
        break;
}







