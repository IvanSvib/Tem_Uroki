﻿//1.Создать массив forbiddenWords, содержащий ключевые слова,
//которые должны быть скрыты в предложении.
//2. Создать переменную sentence для хранения введенного
//предложения.
//3. Инициализировать бесконечный цикл для ввода слов и
//составления предложения.
//4. Вывести приглашение пользователю для ввода слова. Ожидать
//ввода слова с клавиатуры и сохранить его в переменную word.
//5. Проверить, является ли введенное слово ключевым для замены.

//так как я еще не понял суть проблемы, мои коды отчасти будут на английском языке///
using System.Linq;

//string[] forbiddenWords = new string[10];
//forbiddenWords[0] = "Goo";
//forbiddenWords[1] = "goo";
//forbiddenWords[2] = "black";
//forbiddenWords[3] = "Black";
//forbiddenWords[4] = "coal*-";
//forbiddenWords[5] = "Coal";
//forbiddenWords[6] = "Niga";
//forbiddenWords[7] = "niga";
//forbiddenWords[8] = "house";
//forbiddenWords[9] = "House";


//string exit = "";
//string sentence = "";



//do
//{ 

//    Console.Write("Введите слово или предложение:");
//    string word = Console.ReadLine();
//    if (word == "exit") exit = word;
//    if (forbiddenWords.Contains(word))
//        for (int i = 0; i < forbiddenWords.Length; i++)
//        {
//            forbiddenWords[i].Contains(word);
//            word = "(hidden)";
//            sentence = sentence + word + " ";
//            break;
//        }   
//    else sentence = sentence + word + " ";


//} while (exit != "exit");
//Console.WriteLine(sentence);


//Домашнее задание. Тема 18. Урок 2. Работа со строками.
//Метод Split.
//
//Задача 2:
//Напишите программу, которая запрашивает у пользователя
//предложение и определяет, сколько слов в нем содержатся. Для этого
//используйте метод Split() для разделения предложения на отдельные
//слова и подсчитайте их количество. Выведите полученное число на
//экран.
//Пример:
//Введите предложение: Я люблю программирование
//Количество слов: 3


//Задача 1:
//Напишите программу, которая принимает от пользователя строку,
//содержащую числа, разделенные запятой. Используя метод Split(),
//разделите строку на отдельные числа и найдите их сумму. Выведите
//полученную сумму на экран.
//Пример:
//Введите строку чисел: 10, 20, 30, 40, 50
//Сумма чисел: 150

Console.WriteLine("Введите строку чисел:");
int num = int.Parse(Console.ReadLine());



