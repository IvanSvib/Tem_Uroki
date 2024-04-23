//Домашнее задание. Тема 13. Урок 1. Циклы while и do
//while.

//Console.WriteLine("Отгадайте число, которое загодал компьютер от 1 до 5.");
//int men = 0;
//int comp = 0;
//int count = 0;
//do 
//{
//    Random random = new Random();
//    int n = random.Next(1, 5);
//    int m = int.Parse(Console.ReadLine());

//    if (m == n)
//    {
//        Console.WriteLine("ПОБЕДА");
//        ++men;
//    }
//    else if (m > 5)
//        {

//        Console.WriteLine($"Вы играете не по правилам!!!");
//        ++comp;
//    }
//    else if (m != n)
//    {
//          Console.WriteLine($" Число было {n}");
//        ++comp;

//    }
//        count++;
//}
//while (count<3);
//if (men > comp)
//{
//    Console.WriteLine($"Вы победили {men}/{comp} -Победа");
//}
//else if (men < comp)
//{
//    Console.WriteLine($"Победил компьютер {men}/{comp} -Поражение");
//}

//Домашнее задание. Тема 11. Урок 4. Условные операторы
//и класс Random.



Console.WriteLine("Введите свой возраст:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("За кого вы будете болеть, если проиграете или не будете допущены к участию в выборах?" +
"\n● 1 - Незнайка" +
"\n● 2 - Лунтик" +
"\n● 3 - Карлсон" +
"\n● 4 - Дядя Фёдор");
int name = int.Parse(Console.ReadLine());
int name1 = 1;
int name2 = 2;
int name3 = 3;
int name4 = 4;


switch (name)

{
    case 1: Console.Write("А у тебя в животе арбуз вырастет!!!"); break;
    case 2: Console.Write("Я родился!!!"); break;
    case 3: Console.Write("Я самый больной в мире человек, а не найдется у тебя баночки варенья!"); ; break;
    case 4: Console.Write("Для того чтобы продать что-нибудь ненужное, нужно купить что-нибудь ненужное "); break;
    default:
        Console.Write("Нет такого кандидата!!! ");
        break;


}




if (age < 18)
{
    Console.WriteLine($"\nВы слишком молоды для участия в выборах:");
}
else if (age <= 36 && age >= 18)
{
    Console.WriteLine($"\nВы можете участвовать в выборах в качестве депутата:");
}
else if (age <= 65 && age >= 36)
{
    Console.WriteLine($"\nВы можете участвовать в выборах в качестве кандидата в президенты:");
}
else
{

    Console.WriteLine($"\nВаш возраст слишком велик для участия в выборах:");

}

//Дополнительные задания на 10ку:



Random rand = new Random();
int n = rand.Next(13);
switch (n)
{
    case 1: Console.WriteLine("Сколько дней в ЯНВАРЕ ?"); break;
    case 2: Console.WriteLine("Сколько дней в ФЕВРАЛЕ ?"); break;
    case 3: Console.WriteLine("Сколько дней в МАРТЕ ?"); break;
    case 4: Console.WriteLine("Сколько дней в АПРЕЛЕ ?"); break;
    case 5: Console.WriteLine("Сколько дней в МАЕ ?"); break;
    case 6: Console.WriteLine("Сколько дней в ИЮНЕ ?"); break;
    case 7: Console.WriteLine("Сколько дней в ИЮЛЕ ?"); break;
    case 8: Console.WriteLine("Сколько дней в АВГУСТЕ ?"); break;
    case 9: Console.WriteLine("Сколько дней в СЕНТЯБРЕ ?"); break;
    case 10: Console.WriteLine("Сколько дней в ОКТЯБРЕ ?"); break;
    case 11: Console.WriteLine("Сколько дней в НОЯБРЕ ?"); break;
    case 12: Console.WriteLine("Сколько дней в ДЕКАБРЕ ?"); break;
}

Console.Write($"Введите количество дней.") ;
int m = int.Parse(Console.ReadLine());
if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
    if (m == 31) Console.WriteLine("Победа");
    else Console.WriteLine($"Поражение! В этом месяце 31 день");
else if (n == 4 || n == 6 || n == 9 || n == 11)
    if (m == 30) Console.WriteLine("Победа");
    else Console.WriteLine($"Поражение! В этом месяце 30 дней");
else if (n == 2 && (m == 28 || m == 29)) Console.WriteLine("Победа");
else Console.WriteLine($"Поражение! В этом месяце 28 или 29 дней");





