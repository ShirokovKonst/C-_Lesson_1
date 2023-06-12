using System;

namespace C__lesson1_HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine()!);
            if(a % 2 == 0)
            Console.WriteLine("Число четное");
            else
            Console.WriteLine("Число нечетное");
        }
    }
}
