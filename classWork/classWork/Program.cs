﻿using System;

namespace classWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ? OPERATER IF ELSE SHORTCUT
            ////////////////////////////
            //Console.WriteLine("\nINPUT");
            //Console.WriteLine("What is John's Score?");
            //int scoreJohn = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What is Dan's Score?");
            //int scoreDan = Convert.ToInt32(Console.ReadLine());

            //string response = scoreJohn > scoreDan ? "Good Score!" : "Bad Score!";

            //Console.WriteLine("\nOUTPUT");
            //Console.WriteLine("Hey John, you have " + response);

            

            //SWITCH STATEMENT
            /////////////////
            //Console.Write("INPUT -- Eneter the day of the week: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("OUTPUT -- ");
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Please Enter a valid day - from 1 to 7");
            //        break;
            //}
            //Console.WriteLine("\nHave a Nice Day!!!");
            /////////////////////
            //EXAPMPLE 2
            ///////////////////////
            //Console.Write("INPUT -- Eneter the day of the week: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //string output = "";

            //switch (day)
            //{
            //    case 1:
            //        output = "Monday";
            //        break;
            //    case 2:
            //        output = "Tuesday";
            //        break;
            //    case 3:
            //        output = "Wednesday";
            //        break;
            //    case 4:
            //        output = "Thursday";
            //        break;
            //    case 5:
            //        output = "Friday";
            //        break;
            //    case 6:
            //        output = "Saturday";
            //        break;
            //    case 7:
            //        output = "Sunday";
            //        break;
            //    default:
            //        output = "Please Enter a valid day - from 1 to 7";
            //        break;
            //}
            //Console.Write("OUTPUT -- " + output);
            //Console.WriteLine("\nHave a Nice Day!!!");
            //Console.ReadKey();
            //EXAPMLE 3
            ///////////////
            Console.Write("INPUT -- Eneter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string output = "";
            if (day <= 7)
            {

                switch (day)
                {
                    case 1:
                        output = "Monday";
                        break;
                    case 2:
                        output = "Tuesday";
                        break;
                    case 3:
                        output = "Wednesday";
                        break;
                    case 4:
                        output = "Thursday";
                        break;
                    case 5:
                        output = "Friday";
                        break;
                    case 6:
                        output = "Saturday";
                        break;
                    case 7:
                        output = "Sunday";
                        break;
                    default:
                        output = "DONE";
                        break;
                }
            } 
            else
            {
                output = "Please Enter a valid day - from 1 to 7";
            }
            Console.Write("OUTPUT -- " + output);
            Console.WriteLine("\nHave a Nice Day!!!");
            Console.ReadKey();

        }
    }
}
