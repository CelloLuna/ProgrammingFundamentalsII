using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number One: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number One: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Boolean condition = num1 > num2;
            Console.WriteLine("\nBoolean condition is: " + condition);

            if (condition == true)
            {
                Console.WriteLine("\nNumber one is larger than number two");
                Console.WriteLine(num1 + " is larger than " + num2);
            } 
            else if (condition == false)
            {
                Console.WriteLine("\nNumber one is not greater than number two");
                Console.WriteLine(num1 + " is larger than " + num2);
            }
        }
    }
}
