using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAndSummOfEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Используя вложенные циклы, вывести таблицы умножения от второй до шестой.
            for (int i = 2; i <= 6; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int mult = i * j;
                    Console.WriteLine($"{i} * {j} = {mult}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
