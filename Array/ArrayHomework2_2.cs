using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //Дан массив целых чисел. Переписать все положительные элементы во второй массив, а остальные - в третий
    {
        static void ArrayHomework2_2()
        {
            var n = Convert.ToDouble(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[] second_array = { };
            int[] third_array = { };

            foreach (int element in array)
            {
                if (element > 0)
                {
                    Array.Resize(ref second_array, second_array.Length + 1);
                    second_array[second_array.Length - 1] = element;
                }
                else
                {
                    Array.Resize(ref third_array, third_array.Length + 1);
                    third_array[third_array.Length - 1] = element;
                }
            }

            Console.WriteLine("Элементы 2-ого массива: ");
            foreach (int element in second_array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine("\nЭлементы 3-ого массива: ");
            foreach (int element in third_array)
            {
                Console.Write($"{element} ");
            }
            Console.ReadLine();
        }
    }
}
