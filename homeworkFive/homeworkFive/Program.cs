using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            whileLoop WHILE = new whileLoop();
            WHILE.While();

            doWhileLoop DOWHILE = new doWhileLoop();
            DOWHILE.doWhile();
        }
    }
}
