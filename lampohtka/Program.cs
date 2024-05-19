
char[,] lamp1 = new char[11, 6]
    {
{' ',' ','X','X',' ',' '},
{' ','X','X','X','X',' '},
{'X','X','X','X','X','X'},
{' ','X','X','X','X',' '},
{' ',' ','X','X',' ',' '},
{' ',' ','X','X',' ',' '},
{' ',' ','X','X',' ',' '},
{' ',' ','X','X',' ',' '},
{' ',' ','X','X',' ',' '},
{' ',' ','X','X',' ',' '},
{' ','X','X','X','X',' '},
    };


char[,] copylamp1 = new char[lamp1.GetLength(0), lamp1.GetLength(1)];

    for (int i = 0; i < lamp1.GetLength(0); i++)
    {
        for (int j = 0; j < lamp1.GetLength(1); j++)
        {
            copylamp1[i, j] = lamp1[i, j];
        }
    }

    for (int i = 0; i < lamp1.GetLength(0); i++)
    {

        for (int j = 0; j < lamp1.GetLength(1); j++)
        {
            Console.Write(lamp1[i, j]);
        }
        Console.WriteLine();

    }
Console.WriteLine("Выключить лампочку?");
string on0ff = Console.ReadLine();

while (on0ff != "exit")
{ 
    if (on0ff == "yes")
{
        Console.Clear();
        for (int i = 0; i < lamp1.GetLength(0); i++)
        {
 
            for (int j = 0; j < lamp1.GetLength(1); j++)
            {
 
                lamp1[1, 2] = ' ';
                lamp1[1, 3] = ' ';
                lamp1[2, 1] = ' ';
                lamp1[2, 2] = ' ';
                lamp1[2, 3] = ' ';
                lamp1[2, 4] = ' ';
                Console.Write(lamp1[i, j]);

            }
            Console.WriteLine();
        }
 
        Console.WriteLine("Включить лампочку?");
        on0ff = Console.ReadLine();
        if (on0ff == "yes")
        {
             Console.Clear();
             for (int i = 0; i < copylamp1.GetLength(0); i++)
             {
        
                 for (int j = 0; j < copylamp1.GetLength(1); j++)
                 {
                     Console.Write(copylamp1[i, j]);
                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Выключить лампочку?");
             on0ff = Console.ReadLine();
        }
        if (on0ff != "yes")
        {
            Console.WriteLine("нет такой команыды!" +

                "\n Можно только выйти - exit " +
                "\nили" +
                "\nВключить лампочку - yes");
            on0ff = Console.ReadLine();
            if (on0ff == "yes")
            {
                Console.Clear();
                for (int i = 0; i < copylamp1.GetLength(0); i++)
                {

                    for (int j = 0; j < copylamp1.GetLength(1); j++)
                    {
                        Console.Write(copylamp1[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Выключить лампочку?");
                on0ff = Console.ReadLine();
            }
        }
        
    }



if (on0ff != "yes")
{
    Console.WriteLine("нет такой команыды!" +

            "\n Можно только выйти - exit " +
            "\nили" +
            "\nВыключить лампочку - yes");
    on0ff = Console.ReadLine();
}

  
}































