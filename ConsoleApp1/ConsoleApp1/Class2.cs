using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main3(string[] args)
        {
            //{}==>block
            //
            //Console.Write("Enter Some Value:");

            //int s = Convert.ToInt32(Console.ReadLine());
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //Console.WriteLine("Value recieved from user:-  "+(Convert.ToInt32(s1) + Convert.ToInt32(s2)));

            //int choice = 2;

            // Program to Print All Days Of Week
             Console.Write("Enter Some Value:");
             int day;
             Console.WriteLine("Enter The week Day Number");
             day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Hi I am Default Case");
                    break;
            }
        }
    }
}
