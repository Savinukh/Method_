<<<<<<< HEAD
﻿using System;

namespace Method
{
    class Program
    {
        static void Main()
        {
            int repeat = 1;
            do
            {
                MethodSquare();
                MethodRedLine();
                MethodYellowLine();
                Console.WriteLine("Хотите попробовать еще раз? да - 1, нет - 0");
                repeat = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (repeat != 0);
            Console.WriteLine("Программа закончена");
            Console.ReadKey();

        }
        static void MethodSquare()
        {
            Console.Write("Введите высоту стороны квадрата:\t");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите символ:\t");
            string b = Console.ReadLine();
            for (int i = 1; i <= a; i++)
            {
                for (int n = 1; n <= a; n++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" {0}", b);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void MethodRedLine()
        {
            Console.Write("Введите длину красной линии:\t");
            int length = int.Parse(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("─");
                Console.ResetColor();
            }
            Console.WriteLine("\n");

        }
        static void MethodYellowLine()
        {
            Console.Write("Введите длину линии:\t");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите количество линий:\t");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                for (int n = 1; n <= length; n++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("─");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
=======
﻿using System;

namespace Method
{
    class Program
    {
        static void Main()
        { int n = 0;
            do
            {
                MethodRedLine();
                MethodSquare();
                MethodYellowLine();
                Console.WriteLine("Хотите попробывать еще раз? да - 1, нет - 0");
                int answer = int.Parse(Console.ReadLine());
                Console.Clear();
                Main();
              
                
            }
            while (n == 1);
            

        }
        static void MethodSquare()
       {
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void MethodRedLine()
        {
            Console.Write("Введите длину красной линии:\t");
            int length = int.Parse(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("─");
                Console.ResetColor();
            }
            Console.WriteLine("\n");
                        
        }
        static void MethodYellowLine()
        {
            Console.Write("Введите длину линии:\t");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите количество линий:\t");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                for (int n = 1; n <= length; n++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("─");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            MethodSquare();
        } 
}
}
>>>>>>> main
