﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s));

            double sum = 0;
            foreach ( var a in array)
            {
                sum += a;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
