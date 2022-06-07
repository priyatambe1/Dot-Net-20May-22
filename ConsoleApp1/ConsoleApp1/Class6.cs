using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
    {
        static void Main7(string[] args)
        {
            // Pattern3
            Console.WriteLine(" Enter Number Of rows :");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = rows; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }

            for (int i = 2; i <= rows; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
