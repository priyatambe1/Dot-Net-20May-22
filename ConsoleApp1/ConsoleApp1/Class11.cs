using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class11
    {
        static void Main12(string[] args)
        {
            //Factorial Number Using Function
            Console.Write("Enter a Number:" );
            factorial();
        }

        static void factorial()
        {
            int i, fact = 1, n;
            n= Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                fact = fact * i;
            Console.Write("factorial of " + n + " is : " + fact);
                
        }
    }
}
