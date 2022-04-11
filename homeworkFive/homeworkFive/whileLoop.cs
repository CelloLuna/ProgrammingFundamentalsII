using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkFive
{
    internal class whileLoop
    {
        public void While()
        {
            Console.Write("Enter Start Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter End Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OUTPUT: ");
            while (num1 <= num2)
            {
                Console.WriteLine("While Loop Starts with value: " + num1);
                num1++;
                Console.WriteLine("While Loop After Increment: " + num1);
                Console.WriteLine("BLOCK ENDS");
            }
            Console.WriteLine("```````````````````````");
        }
    }
}
