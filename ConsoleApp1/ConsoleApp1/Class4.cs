using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
