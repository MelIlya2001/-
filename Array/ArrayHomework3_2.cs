using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //Дан одномерный массив из 8 элементов. Заменить все элементы массива меньшие 15 их удвоенными значениями. Вывести на экран монитора преобразованный массив.
    {
        static void Main(string[] args)
        {
            var n = Convert.ToDouble(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            Console.Write("Преобразованный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 15)
                {
                    array[i] *= 2;
                }
                Console.Write($"{array[i]} ");
            }
            Console.ReadLine();
        }
    }
}
