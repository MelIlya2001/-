using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //Программа по поиску максимального элемента массива
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
