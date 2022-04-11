using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNotes
{
    internal class whileLoop1
    {
        public void tryWhileLoop()
        {
            Console.WriteLine("While Loop");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Iteration " + i);
                i++;
            }

            Console.WriteLine("Thank You!");

        }
    }
}
