using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodRedLine();
            MethodSquare();
            MethodYellowLine();

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
            Console.ReadKey();
        } 
}
}
