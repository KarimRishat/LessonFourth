using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Program
    {
        enum Mouth
        {
            wide, small
        }
        static void Main(string[] args)
        {
            //Task 1.1
            Console.WriteLine("Task 1.1\nВведите вещественное число:");
            double num = Convert.ToDouble(Console.ReadLine());
            double abs = Math.Sqrt(num * num);
            Console.WriteLine($"Абсолютное значение: {abs}");
            //Task 1.2
            Console.WriteLine("\nTask 1.2\nВведите первое число:");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double num1 = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(num * num) > Math.Sqrt(num1 * num1))
            {
                num /= 2;
            }
            Console.WriteLine("Первое число: {0}, второе число: {1}",num,num1);
            //Task 1.3
            Mouth mouthSize = Mouth.wide;
            Console.WriteLine("\nTask 1.3\nВведите животное");
            string s1 = "аллигатор", s2 = Console.ReadLine();
            bool equality = Convert.ToBoolean(String.Compare(s1,s2, true));
            if (!equality)   //приведение к одинаковому регистру
            {
                mouthSize = Mouth.small;
            }
            Console.WriteLine("mouthSize = " + mouthSize);
            //Task 1.4
            try
            {
                Console.WriteLine("\nTask 1.4\nЗаходит в бар ...");
                string s = Console.ReadLine();
                if (!Convert.ToBoolean(String.Compare(s, "Jabroni", true)))
                {
                    Console.WriteLine("Patron Tequila");
                }
                else
                {
                    if (!Convert.ToBoolean(String.Compare(s, "School Counseler", true)))
                    {
                        Console.WriteLine("Anything with Alcohol");
                    }
                    else
                    {
                        if (!Convert.ToBoolean(String.Compare(s, "Programmer", true)))
                        {
                            Console.WriteLine("Hipster Craft Beer");
                        }
                        else
                        {
                            if (!Convert.ToBoolean(String.Compare(s, "Bike Gang Member", true)))
                            {
                                Console.WriteLine("Moonshine");
                            }
                            else
                            {
                                if (!Convert.ToBoolean(String.Compare(s, "Politician", true)))
                                {
                                    Console.WriteLine("Your tax dollars");
                                }
                                else
                                {
                                    if (!Convert.ToBoolean(String.Compare(s, "Rapper", true)))
                                    {
                                        Console.WriteLine("Cristal");
                                    }
                                    else
                                    { Console.WriteLine("Beer"); }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Task 1.5
            Console.WriteLine("\nTask 1.5\nВведите строку:");
            s1 = "english";
            s2 = Console.ReadLine();
            s2 = s2.ToLower();
            Console.WriteLine(s2.Contains(s1));
            //Task 2.1
            double sum = 1, x = 1;
            for (int i = 1; i<9;i++)
            {
                x *= 3;
                sum += 1 / x;
            }
            Console.WriteLine("\nTask 2.1\nСумма равна: "+sum);
            //Task 2.2
            double sHome = 0, dist = 0;
            int N = 100;
            for (int i = 1; i <= N; i++)
            {
                dist += (double)1 / i;
                if (i % 2 == 0)
                {
                    sHome -= (double)1 / i;
                }
                else
                    sHome += (double)1 / i;
            }
            Console.WriteLine("До дома после N этапа: {0}, всего прошел: {1}",sHome,dist);
            //Task 2.3
            double janFalls = 0, marchFalls = 0;
            Random rnd = new Random();
            for(int i =1; i <32; i++)
            {
                janFalls += rnd.NextDouble()*50;
                marchFalls += rnd.NextDouble() * 50;
            }
            Console.WriteLine("\nTask 2.3\nСреднее за январь: {0}, за март: {1}",Math.Round(janFalls/31,2),Math.Round(marchFalls/31,2));
            
            //Task 3.1
            int a1 = 1, a2 = 2, b1 = 1, b2 = 1;
            while (Math.Sqrt(((double)a1/b1 - (double)a2 /b2)*((double)a1 / b1 - (double)a2 / b2)) > 0.001)
            {
                int a3 = a2;
                a2 += a1;
                a1 = a3;
                int b3 = b2;
                b2 += b1;
                b1 = b3;
            }
            Console.WriteLine("\nTask 3.1\nПервое число: {0} = {1} / {2} ",Math.Round((double)a2/b2,2),a2,b2);
            //Task 3.2
            Console.WriteLine("\nTask 3.2\nВведите число n:");
            int n32 = Convert.ToInt32(Console.ReadLine());
            int xSqr = 1;
            while (xSqr*xSqr<=n32)
            {
                xSqr++;
            }
            Console.WriteLine("Квадрат числа {0} больше {1}",xSqr,n32);
            num = 100;
            num1 = 80;
            Console.WriteLine("\nTask 3.3\nС предусловием от {0} до {1}",num,num1);
            while (num >= num1)
            {
                Console.WriteLine(num);
                num--;
            }
            num = 100;
            num1 = 80;
            Console.WriteLine("\nС постусловием от {0} до {1}", num, num1);
            do
            {
                Console.WriteLine(num);
                num--;
            } while (num >= num1);
            //Task 3.4
            int max = 5000, kmax = 0;
            num = 39;
            kmax = (max / 39) * 39;
            Console.WriteLine("\nTask 3.4\nМаксимальное число, нацело делящееся на {0} и не превышающее {1}: {2}",num,max,kmax);
            //Task 3.5
            int count5 = 5, count1 = 5;
            Console.WriteLine("\nTask 3.5\nПятерки:");
            for (int i = 1; i<count5+1;i++)
            {
                for(int j =1; j<i+1;j++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЕдинички:");
            for (int i = count1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
            //Task additional Chess
            Console.WriteLine("\nAddTask\nВведите координаты ладьи: ");
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            int c = Convert.ToInt32(Console.ReadLine()), d = Convert.ToInt32(Console.ReadLine());
            //a Ладья
            if (a==c || b == d)
            {
                Console.WriteLine($"Ладья на {a} {b} угрожает {c} {d}");
            }
            else
            {
                Console.WriteLine("Ладья не угрожает");
            }
            //б Слон
            Console.WriteLine("\nВведите координаты слона: ");
            a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            c = Convert.ToInt32(Console.ReadLine()); d = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(a-c) == Math.Abs(b-d))
            {
                Console.WriteLine($"Слон {a} {b} угрожает {c} {d} ");
            }
            //В Король
            Console.WriteLine("\nВведите координаты короля: ");
            a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            c = Convert.ToInt32(Console.ReadLine()); d = Convert.ToInt32(Console.ReadLine());
            if ((Math.Abs(a-c) == 1 && Math.Abs(b-d) < 2)|| (Math.Abs(b-d) == 1 && Math.Abs(a-c) <2))
            {
                Console.WriteLine("Король может попасть на это поле");
            }
            else
                Console.WriteLine("Король не может попасть на это поле");
            //г Ферзь
            Console.WriteLine("\nВведите координаты ферзя: ");
            a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            c = Convert.ToInt32(Console.ReadLine()); d = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(a - c) == Math.Abs(b - d) || a == c || b == d)
            { Console.WriteLine("Ферзь угрожает"); }
            else
                Console.WriteLine("ферзь не угрожает");
            //д Белая пешка
            Console.WriteLine("\nВведите координаты белой пешки: ");
            a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            c = Convert.ToInt32(Console.ReadLine()); d = Convert.ToInt32(Console.ReadLine());
            if (d-b == 1 && a == c)
            {
                Console.WriteLine("Белая пешка может попасть на это поле");
            }
            else
            { if (Math.Abs(a - c) == 1 && (d - b == 1))
                {
                    Console.WriteLine("Белая пешка бьет фигуру противника");
                }
            else
                    Console.WriteLine("Белая пешка не может попасть на это поле");
            }
            //е Черная пешка
            Console.WriteLine("\nВведите координаты черной пешки: ");
            a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            c = Convert.ToInt32(Console.ReadLine()); d = Convert.ToInt32(Console.ReadLine());
            if (b-d == 1 && a == c)
            {
                Console.WriteLine("Черная пешка может попасть на это поле");
            }
            else
            {
                if (Math.Abs(a - c) == 1 && (b - d == 1))
                {
                    Console.WriteLine("Черная пешка бьет фигуру противника");
                }
                else
                    Console.WriteLine("Черная пешка не может попасть на это поле");
            }
            //ж Конь
            Console.WriteLine("\nВведите координаты коня: ");
            a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты поля");
            c = Convert.ToInt32(Console.ReadLine()); d = Convert.ToInt32(Console.ReadLine());
            if ((Math.Abs(a-c) == 1 && Math.Abs(b-d) == 2) || (Math.Abs(a-c) == 2 && Math.Abs(b-d) == 1))
            {
                Console.WriteLine("Конь может попасть на это поле");
            }
            else
                Console.WriteLine("Конь попасть не может");
            Console.ReadKey();
        }
    }
}
