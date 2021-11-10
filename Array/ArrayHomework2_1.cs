using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //Дан одномерный массив, состоящий из N целочисленных элементов. Ввести массив с клавиатуры. Найти минимальный элемент. Вывести индекс минимального элемента на экран
    {
        static void ArrayHomework2_1()
        {
            var n = Convert.ToDouble(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int min_elem = array[0];
            int min_index = 0;          
            for (int i = 0; i < array.Length; i++)
            {
                if (min_elem > array[i])
                {
                    min_elem = array[i];
                    min_index = i;
                }
            }
            Console.WriteLine($"Минимальный элемент массива - {min_elem}");
            Console.WriteLine($"Индекс минимального элемента массива - {min_index}");
            Console.ReadLine();
        }
    }
}
