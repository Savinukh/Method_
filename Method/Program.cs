using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodRedLine();
            MethodSquare();
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
            Console.ReadKey();
        }
        static void MethodRedLine()
        {
            Console.WriteLine("Введите длины красной линии:\t");
            int length = int.Parse(Console.ReadLine());
            for (int i = 1; i <= length; i++)
        
       


    }
}
}
