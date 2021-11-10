using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //Дан одномерный массив, состоящий из N целочисленных элементов. Ввести массив с клавиатуры. Найти максимальный элемент. Вывести массив на экран в обратном порядке.
    {
        static void ArrayHomework1()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int max = array[0];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine($"\nМаксимальный элемент массива - {max}");
            Console.ReadLine();
        }
    }
}
