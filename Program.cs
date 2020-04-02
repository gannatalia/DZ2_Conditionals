using System;

namespace DZ2_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 
            // Пользователь вводит 2 числа (А и В). Если А>В, подсчитать А+В, если А=В, подсчитать А*В, если А<В, подсчитать А-В
            Console.WriteLine("Задание 1");

            int a, b, c;

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                c = a + b;
                Console.Write("значение c = a + b = ");
                Console.WriteLine(c);
            }
            else if (a == b)
            {
                c = a * b;
                Console.Write("значение c = a * b = ");
                Console.WriteLine(c);
            }
            else if (a < b)
            {
                c = a - b;
                Console.Write("значениe c = a - b = ");
                Console.WriteLine(c);
            }
            Console.WriteLine();

            // Задание 2
            // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (Х,Y).

            Console.WriteLine("Задание 2. Определить какой четверти принадлежит точка с координатами (Х,Y)");
            int x, y;

            Console.Write("введи x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи y = ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("точка принадлежит первой четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("точка принадлежит второй четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("точка принадлежит третьей четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("точка принадлежит четвертой четверти");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("точка принадлежит началу координат");
            }
            Console.WriteLine();

            // Задание 3
            // Пользователь вводит 3 числа (А и В, С). Выведите их в консоль в порядке возрастания.

            Console.WriteLine("Задание 3. Пользователь вводит 3 различных числа (А и В, С). Выведите их в консоль в порядке возрастания.");

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }
            else if (a < b && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else if (a < c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if (a > b && b > c)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            else if (a > b && b < c)
            {
                if (a > c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
                else if (a < c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
            }

            else if (a == b && b == c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            Console.WriteLine();

            // Задание 4
            // Пользователь вводит 3 числа (А, В и С). Выведите в консоль решение (значение Х) квадратного уравнения стандартного вида, где a*x2+bх=c

            Console.WriteLine("Задание 4. Пользователь вводит 3 числа (А, В и С). Выведите в консоль решение (значение Х) квадратного уравнения стандартного вида, где a*x2+bх=c");

            double d, x1, x2;

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи c = ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("решений нет");
            }
            else if (d == 0)
            {
                x = (-b) / 2 / a;
                Console.Write(x);
            }
            else if (d > 0)
            {
                x1 = ((-b) + Math.Sqrt(d)) / 2 / a;
                x2 = ((-b) - Math.Sqrt(d)) / 2 / a;
                Console.WriteLine("x1 = ");
                Console.WriteLine(x1);
                Console.WriteLine("x2 = ");
                Console.WriteLine(x2);
            }
            Console.WriteLine();

            // Задание 5
            //Пользователь вводит двухзначное число. Выведите в консоль прописную запись этого числа. Например при вводе "25" в консоль будет выведено "двадцать пять".

            Console.WriteLine("Задание 5");

            Console.Write("введи двузначное число a = ");
            a = Convert.ToInt32(Console.ReadLine());

            int q = a / 10;
            int w = a % 10;

            switch (q)
            {
                case 1:
                    if (w == 0)
                    {
                        Console.WriteLine("десять");
                    }
                    else if (w == 1)
                    {
                        Console.WriteLine("одиннадцать");
                    }
                    else if (w == 2)
                    {
                        Console.WriteLine("двенадцать");
                    }
                    else if (w == 3)
                    {
                        Console.WriteLine("тринадцать");
                    }
                    else if (w == 4)
                    {
                        Console.WriteLine("четырнадцать");
                    }
                    else if (w == 5)
                    {
                        Console.WriteLine("пятнадцать");
                    }
                    else if (w == 6)
                    {
                        Console.WriteLine("шестнадцать");
                    }
                    else if (w == 7)
                    {
                        Console.WriteLine("семнадцать");
                    }
                    else if (w == 8)
                    {
                        Console.WriteLine("восемнадцать");
                    }
                    else if (w == 9)
                    {
                        Console.WriteLine("девятнадцать");
                    }
                    break;
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
                case 7:
                    Console.Write("семьдесят ");
                    break;
                case 8:
                    Console.Write("восемьдесят ");
                    break;
                case 9:
                    Console.Write("девяносто ");
                    break;
                default:
                    break;
            }

            switch (w)
            {
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;

                default:
                    break;
            }
    }
}
