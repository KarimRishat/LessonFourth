using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4.1
            Console.WriteLine("Task 4.1\nВведите число от 1 до 365 (номер дня в году):");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime();
            if (day < 1 || day > 365)
                Console.WriteLine("Столько дней не бывает!");   //Task 4.2
            else
            {
                dt = dt.AddDays(day - 1);
                Console.WriteLine(dt.ToString("d MMMM"));
            }
            //Task 4.3
            DateTime dt2 =new DateTime(1,1,1);
            Console.WriteLine("\nTask 4.3\nВведите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            day = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year%400 == 0))
            {
                if (day < 1 || day > 366)
                    Console.WriteLine("Столько дней не бывает!");  
                else
                {
                    dt2 = dt2.AddYears(year - 1);
                    dt2 = dt2.AddDays(day - 1);
                    Console.WriteLine(dt2.ToString("d MMMM yyy"));
                }
            }
            else
            {
                if (day < 1 || day > 365)
                    Console.WriteLine("Столько дней не бывает!");   
                else
                {
                    dt2 = dt2.AddYears(year - 1);
                    dt2 = dt2.AddDays(day - 1);
                    Console.WriteLine(dt2.ToString("d MMMM yyy"));
                }
            }
            Console.ReadKey();
        }
    }
}
