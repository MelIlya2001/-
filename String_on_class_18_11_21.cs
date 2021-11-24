using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3. Является ли слово полиндромом?
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            bool isPolindrom = true;

            for (int i = 0; i < (word.Length / 2); i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPolindrom = false;
                    break;
                }
            }

            Console.WriteLine($"Утверждение, что слово '{word}' является полиндромом - {isPolindrom}");
            Console.ReadLine();
        }
    }
}



////18.11 Задание 1. Реверсивная строка
//Console.Write("Оригинальная строка: ");
//string str = Console.ReadLine();
//string reverce_str = "";

//for (int i = str.Length - 1; i >= 0; i--)
//{
//    reverce_str += str[i];
//}
//Console.WriteLine($"Перевёрнутая строка: {reverce_str}");



////Задание 2. Капитализация текста - изменение первых букв в словах строки на заглавные
//Console.Write("Введите текст: ");
//string[] _words = Console.ReadLine().Split(' ');
//string result = "";
//for (int i = 0; i < _words.Length; i++)
//{
//    result += char.ToUpper(_words[i][0]);
//    for (int j = 1; j < _words[i].Length; j++)
//    {
//        result += _words[i][j];
//    }
//    result += ' ';
//}
//Console.WriteLine(result);
