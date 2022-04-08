using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Both the numbers are the same.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Number Two is greater than Number One");
                Console.WriteLine(num2 + " is greater than " + num1);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Number One is greater than Number Two");
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            Console.WriteLine("Thank you!");

        }
    }
}
