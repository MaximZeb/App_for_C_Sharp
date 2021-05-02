using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
        }
    }
}