using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //В массиве действительных чисел все нулевые элементы заменить на среднее арифметическое всех элементов массива
    {
        static void Array_homework1_2()
        {
            var n = Convert.ToDouble(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s));

            double sum = 0;
          
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = sum;
                }
                Console.Write($"{array[i]} ");
            }
            Console.ReadLine();
        }
    }
}
