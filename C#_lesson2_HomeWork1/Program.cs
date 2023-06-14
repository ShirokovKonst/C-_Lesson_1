using System;

namespace C__lesson2_HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int num = int.Parse(Console.ReadLine());
            while ((num/100<1)^(num/100>10))
            {
                Console.WriteLine("Вы ввели не трехзначное число!");
                Console.WriteLine("Введите трехзначное число");
                num = int.Parse(Console.ReadLine());
            }

            int result = (num/10)%10;
            Console.WriteLine("Вторая цифра числа: " + result);

        }
    }
}
