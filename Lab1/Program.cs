using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double Number = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            double Pow = Double.Parse(Console.ReadLine());

            double Result = Math.Exp(Pow * Math.Log(Number));

            Console.WriteLine($"Результат: {Result}");
            Console.ReadLine();
        }

    }
}
