using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkFive
{
    internal class doWhileLoop
    {
        public void doWhile()
        {
            Console.Write("Enter Start Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter End Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OUTPUT: ");
            do
            {
                Console.WriteLine("Do While Starts at " + num1);
                num1++;
                Console.WriteLine("Do While after increment: " + num1);
                Console.WriteLine("END BLOCK");
            }
            while (num1 <= num2);
        }
    }
}
