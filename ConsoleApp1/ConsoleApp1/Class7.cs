using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        static void Main8(string[] args)
        { 
              // To check No is Palindrome or not
            string s, rev = "";
            Console.WriteLine("Enter the String");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s)
            {
                Console.WriteLine("Entered String is Palindrome", s, rev);
            }
            else
            {
                Console.WriteLine("Entered String is not Palindrome", s, rev);
            }
            Console.ReadLine();
        }
    }

}
