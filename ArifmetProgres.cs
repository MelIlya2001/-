using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа по вычислению первых членов арифметической прогрессии
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма первых {0} членов арифметической прогрессии равна {1}", n, sum);
            Console.ReadLine();

        }
    }
}
