using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //В одномерном числовом массиве D длиной n вычислить сумму элементов с нечетными индексами. Вывести на экран массив D, полученную сумму.
    {
        static void ArrayHomework3_1()
        {
            var n = Convert.ToDouble(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int sum = 0;

            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\nСумма элементов массива с нечётными индексами = {sum}");
            Console.ReadLine();
        }
    }
}
