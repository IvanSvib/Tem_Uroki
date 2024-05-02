
//Нужно разработать программу, которая будет генерировать пароли
//заданной длины для пользователей

//Console.WriteLine("Укажите длину пароля!");
//int lenght = int.Parse(Console.ReadLine());

//Random porol = new Random();
//String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//String randomstring = "";

//for (int i = 0; i < lenght; i++)
//{
//    int x = porol.Next(str.Length);


//    randomstring = randomstring + str[x];
//}

//Console.WriteLine("Ваш пороль (никому не сообщайте его):" + randomstring);



//Напишите программу, случайным образом генерирующую
//температуры от 1 до 100. В случае превышения, устройство
//останавливает работу с выводом значения критической температуры на
//экран.


//int temperature = 0;


//for (int i = 1; temperature <90; i++)
//{
//    Random rnd = new Random();
//    temperature = rnd.Next(1, 101);
//    Console.WriteLine($" Temperatura = {temperature}С");


//}
//if (temperature >= 90)
//{
//    Console.WriteLine($" Temperatura = {temperature}С" +
//        $"\n Остановка устройства.");

//}


//Освоить перебор вложенными циклами, переписать код из второго
//файла и описать алгоритм работы (что за чем идет).

//Консоль запрашивает у пользователя число квадратов ,которое нужно ввести.
Console.Write("Укажите количество квадратов: ");
int quantity = Convert.ToInt32(Console.ReadLine());
//Консоль запрашивает у пользователя сторону квадратов ,которое нужно ввести.
Console.Write("Укажите сторону квадрата: ");
int weigth = Convert.ToInt32(Console.ReadLine());
//Цикл, который повторяет код внутри цикла.
for (int i = 0; i < quantity; i++)
{
    for (int j = 0; j < weigth; j++)
    {/*Цикл, который добавляет "*" и  " " пока  j < weigth по колв-во стороны квадрата*/
        Console.Write("*");
        Console.Write(" ");
    }
    Console.WriteLine();
    for (int k = 0; k < weigth - 2; k++)
    {/*Цикл, который добавляет "*" пока  k < weigth по колв-во стороны квадрата*/
        Console.Write("*");
        for (int l = 0; l < weigth + weigth - 2; l++)
        {/*Цикл, который добавляет " " пока  l < weigth по колв-во стороны квадрата*/
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }
    for (int m = 0; m < weigth; m++)
    {/*Цикл, который добавляет " " и "*" пока  m < weigth по колв-во стороны квадрата*/
        Console.Write("*");
        Console.Write(" ");
    }
}

   





