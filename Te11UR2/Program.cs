
////Домашнее задание. Тема 11. Урок 2. Условный оператор.

//Console.WriteLine("Введите текущую температуру:");
//int c = int.Parse(Console.ReadLine());
//if (c > 20)
//{
//    Console.Write(" На прогулку выходят СЛОНЫ, ЖИРАФЫ, ЛЬВЫ.");
//}
//else if (c < 20 && c>0)
//{
//    Console.Write(" На прогулку выходят МЕДВЕДИ, ВОЛКИ, ПИНГВИНЫ.");
//}
//else if (c == 20)
//{
//    Console.Write(" На прогулку выходят КЕНГУРУ.");
//}
//else
//{
//    Console.Write(" Животные сидят дома.");
//}


//Домашнее задание. Тема 11. Урок 3. Условные операторы
//и класс Random.


//Console.WriteLine("Введите число от 0 до 5.");
//int x = int.Parse(Console.ReadLine());
//Random random = new Random();
//int y = random.Next(0, 6);
//Console.WriteLine($"{y}");

//if (x == y)
//{
//    Console.WriteLine(" VICTORY!!!");
//}
//else
//{
//    Console.WriteLine(" DEFEAT( ");
//}

Console.WriteLine("Введите порядковый номер месяца.");
int namberMonth = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите температуру.");
int c = int.Parse(Console.ReadLine()!);

if (c > 0)
{
    if (namberMonth == 1) ;
    else if (namberMonth == 2) ;
    else if (namberMonth == 3) ;
    Console.WriteLine("Дождливая Зима.");


}
else if (c <= 0)
    switch (namberMonth)
{ 



    case 1: Console.WriteLine("January."); break;
case 2: Console.WriteLine("February."); break;
case 3: Console.WriteLine("March."); break;
case 4: Console.WriteLine("April."); break;
case 5: Console.WriteLine("May."); break;
case 6: Console.WriteLine("June."); break;
case 7: Console.WriteLine("July."); break;
case 8: Console.WriteLine("August."); break;
case 9: Console.WriteLine("Sentember."); break;
case 10: Console.WriteLine("October."); break;
case 11: Console.WriteLine("November."); break;
case 12: Console.WriteLine("December."); break;
default: Console.WriteLine("There is no such month."); break;

}







