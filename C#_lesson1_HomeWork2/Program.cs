using System;

namespace C__lesson1_HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите третье число: ");
            int c = int.Parse(Console.ReadLine()!);
            if (a>b)
            {   if (a>c)
                Console.WriteLine("Первое число наибольшее");
                else 
                Console.WriteLine("Третье число наибольшее");
            }
            else
            {
                if (b>c)
                Console.WriteLine("Второе число наибольшее");
                else
                Console.WriteLine("Третье число наибольшее");
            }
            


        }
    }
}
