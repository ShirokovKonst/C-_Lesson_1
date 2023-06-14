using System;

namespace C__lesson2_HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру от 1 до 7");
            int num = int.Parse(Console.ReadLine());
            while ((num<1)^(num>7))
            {
                Console.WriteLine("Вы ввели цифру меньше 1 или больше 7!");
                Console.WriteLine("Введите цифру от 1 до 7");
                num = int.Parse(Console.ReadLine());
            }
            if (num >= 6)
            Console.WriteLine("Да, это выходной");
            else
            Console.WriteLine("Нет, это рабочий день");
        }
    }
}
