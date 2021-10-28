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
            //Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m.
            Console.Write("Введите длину катета - ");
            int m = Convert.ToInt32(Console.ReadLine());
            string c = "";
            for (int i = 0; i < m; i++)
            {
                c += "*";
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
