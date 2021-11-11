using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program                                               //Программа по номеру дня недели определяет его название
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели - ");
            int week = Convert.ToInt32(Console.ReadLine());

            string name_day_week = "";
            switch (week)
            {
                case 1:
                    name_day_week = "Понедельник";
                    break;
                case 2:
                    name_day_week = "Вторник";
                    break;
                case 3:
                    name_day_week = "Среда";
                    break;
                case 4:
                    name_day_week = "Четверг";
                    break;
                case 5:
                    name_day_week = "Пятница";
                    break;
                case 6:
                    name_day_week = "Суббота";
                    break;
                case 7:
                    name_day_week = "Воскресенье";
                    break;
                default:
                    name_day_week = "Ошибка!Введено некоректное число. Введите число от 1 до 7";
                    break;
            }
            Console.WriteLine($"День недели под номером {week} - {name_day_week}");
            Console.ReadLine();
        }
    }
}
