using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string Number = Console.ReadLine();

            if (Number.Length > 1)
            {
                char[] Digits = Number.ToCharArray();
                char SecondDigits = Digits[1];
                Digits[1] = Digits[Digits.Length - 1];
                Digits[Digits.Length - 1] = SecondDigits;
                Console.WriteLine($"Измененное число: {new string(Digits)}");
                Console.ReadLine();
                
            }
        }
    }
}
