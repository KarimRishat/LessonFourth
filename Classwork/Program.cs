using System;

namespace Classwork
{
    class Program
    {
        public enum Card { Шестерка, Семерка, Восьмерка, Девятка, Десятка, Валет, Дама, Король, Туз};   //для Task4
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1\nВведите трехзначное число:");
        Input:
            int digit3 = Convert.ToInt32(Console.ReadLine());
            if (digit3 < 100 || digit3 > 999)
            {
                Console.WriteLine("Значение некорректно, введите заново:");
                goto Input;
            }
            if (digit3%10 == digit3/100)
            {
                Console.WriteLine("Палиндром");
            }
            else
                Console.WriteLine("Не палиндром");
            //Task 2
            Console.WriteLine("\nTask 2\nВведите а и b (размеры форточки в см):");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите d (диаметр головы Васи в см):");
            float d = Convert.ToSingle(Console.ReadLine());
            if ((d <= (a - 2)) && (d <= (b - 2))) //1+1см зазор с каждой стороны
            {
                Console.WriteLine("Вася пролезет");
            }
            else
            {
                Console.WriteLine("Вася не пролезет");
            }
            //Task 3
            Console.WriteLine("\nTask 3\nВведите цифру от 1 до 7:");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Некорректное значение");
                    break;
            }
            //Task 4
            try
            {
                Console.WriteLine("\nTask 4\nВведите число от 6 до 14:");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k <6 || k > 14)
                {
                    Console.WriteLine("Нет такой карты");
                }
                else
                    Console.WriteLine((Card)k-6);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка " + ex.Message);
            }
            //Task 5
            Console.WriteLine("\nTask 5");
            int R = 6370;
            for (int h = 1; h<=10; h++)
            {
                double BG = Math.Sqrt((h + R) * (h + R) - R * R);
                Console.WriteLine($"Расстояние до горизонта равно: {Math.Round(BG, 2)}км");
            }
            //Task 6
            Console.WriteLine("\nTask 6\nВведите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
            }
            //Task 7
            try
            {
                Console.WriteLine("\nTask 7\nВведите первое число последовательности, признак окончание последовательности — отрицательное число");
                int num7 = Convert.ToInt32(Console.ReadLine()), count7 = 0, sum7=0;
                while (num7 >= 0)
                {
                    count7++;
                    sum7 += num7;
                    Console.WriteLine("Введите следующее число");
                    num7 = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine($"Среднее арифметическое: {(double)sum7/count7}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка"+ex.Message);
            }
            //TAsk 8
            Console.WriteLine("\nTask 8 (последовательность из 10 чисел)\nВведите первое число последовательности");
            int n1 = Convert.ToInt32(Console.ReadLine()), n2;
            for(int i =2; i<=10;i++)
            {
                Console.WriteLine("Введите следующее число");
                n2 = Convert.ToInt32(Console.ReadLine());
                if(n1>=n2)
                {
                    Console.WriteLine("Последовательность неупорядоченная, {0}-ое число первым нарушает возрастание",i);
                    break;
                }
                if (i == 10)
                {
                    Console.WriteLine("Упорядоченная последовательность");
                }
            }
            //Task 9
            Console.WriteLine("\nTask 9\nВведите первое число последовательности, признак окончание последовательности — 0");
            int num = Convert.ToInt32(Console.ReadLine()), count = 1, sum = 0;
            while (num != 0)
            {
                if(count % 3 == 0)
                {
                    sum += num;
                }
                Console.WriteLine("Введите следующее число");
                num = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            Console.WriteLine("Сумма элементов последовательности, номера позиций которых кратны 3: {0}",sum);
            //Task 10
            Console.WriteLine("\nTask 10\nВведите первое число последовательности, признак окончание последовательности — 0");
            sum = 0;
        Input10:    //Метка для goto
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            if (num!=0)
            {
                Console.WriteLine("Введите следующее число:");
                goto Input10;
            }
            Console.WriteLine("Сумма последовательности "+sum);
            Console.ReadKey();
        }
    }
}
