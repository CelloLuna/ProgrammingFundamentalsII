using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNotes
{
    internal class ifElseShortcut
    {
        public void ifelse()
        {
            // ? OPERATER IF ELSE SHORTCUT
            ////////////////////////////
            Console.WriteLine("\nINPUT");
            Console.WriteLine("What is John's Score?");
            int scoreJohn = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is Dan's Score?");
            int scoreDan = Convert.ToInt32(Console.ReadLine());

            string response = scoreJohn > scoreDan ? "Good Score!" : "Bad Score!";

            Console.WriteLine("\nOUTPUT");
            Console.WriteLine("Hey John, you have " + response);
        }
    }
}
