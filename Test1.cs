using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_r
{
    class Program
    {
        // Враиант 2
        static void Main(string[] args)         
        {
            //Задание номер 3
            //Дана последовательность их n целых чисел. Первое число в последовательности чётное.
            //Найти сумму всех идущих подряд в начале последовательности чётных чисел. Условный оператор не использовать. 
            Console.Write("Введите последовательность чисел (первое число дожно быть чётным): ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int i = 0;
            int sum = 0;

            do
            {
                sum += array[i];
                i++;
            } while (array[i] % 2 == 0);

            Console.WriteLine($"Сумма всех идущих подряд в начале последовательности чётных чисел равна {sum}");
            Console.ReadLine();
        }
    }
}


////Задание номер 1
////Определить, существует ли прямоугольный треугольник со сторонами x,y,z. Если - да,вычислить его площадь.

//Console.Write("Введите длину 1-ой стороны треугольника: ");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите длину 2-ой стороны треугольника: ");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите длину 3-ей стороны треугольника: ");
//double z = Convert.ToDouble(Console.ReadLine());

//if ((x + y > z) && (x + z > y) && (y + z > x))
//{
//    double p = (x + y + z) / 2;
//    double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
//    Console.WriteLine($"Треугольник существует. Площадь треугольника равна {s}");
//}
//else
//{
//    Console.WriteLine("Треугольника с заданными сторонами не существует.");
//}



//Задание номер 2
////Даны два числа А и В (А<В). Найти сумму квадратов всех целых чисел от А до В включительно.
//Console.Write("Введите число A: ");
//int A = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число B: ");
//int B = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//for (int i = A; i <= B; i++)
//{
//    sum += i * i;
//}
//Console.WriteLine($"Сумма квадратов всех целых чисел от A до B: {sum}");