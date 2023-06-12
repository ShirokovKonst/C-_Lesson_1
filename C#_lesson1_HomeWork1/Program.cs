using System;

namespace C__lesson1_HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine()!);
            if(a>b)
            Console.WriteLine("Первое число больше второго ");
            if(b>a)
            Console.WriteLine("Второе число больше первого ");
            if(a==b)
            Console.WriteLine("Числа равны ");


        }
    }
}
