using System;

namespace C__lesson1_HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine()!);
            int i = 1;
            while (i <= a)
            {   
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    if ((i != a-1)&&(i != a))
                    Console.Write(", ");
                }
                i++;
            }
        }
    }
}
