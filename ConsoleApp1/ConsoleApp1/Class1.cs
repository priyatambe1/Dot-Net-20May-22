using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main2(string[] args)
        {


            // Program to check whether person is able to vote or not if age is greater than 60 enter he is senior citizen

            int age = 50;
            if (age < 18)
            {
                Console.WriteLine("Not Able to vote");
            }
            else if (age >= 18)
            {
                Console.WriteLine(" able to vote");
            }
            else if (age > 60)
            {
                Console.WriteLine(" Senior Citizen");

            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }

    }
}
