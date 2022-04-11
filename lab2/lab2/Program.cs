using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number One: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");CannotUnloadAppDomainException 
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2;

            Console.WriteLine(result);
        }
    }
}
