using System;

namespace C__lesson2_HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            if (num/10>1)
            {
                int result = num;
                while (result>999)
                {
                    result = result/10;
                }
                result = result % 10;
                Console.WriteLine("Третья цифра вашего числа: " + result);
            }
            else
                Console.WriteLine("Третьей цифры в числе нет");
        }
    }
}
