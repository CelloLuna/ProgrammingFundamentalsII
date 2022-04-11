using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNotes
{
    internal class doWhileLoop
    {
        public void doWhile()
        {
            Console.WriteLine("Do While Loop: ");

            int i = 0;
            do
            {
                Console.WriteLine("Iteration: " + i);
                i++;
            }
            while (i < 5);
            Console.WriteLine("Thank You!");
        }
    }
}
