using System;

namespace ConsoleApp3
{
    class Program
    {
        // Polymorphism
        //method overloading
        //functions will have same name but they will very in the number of arguments or type of arguments
            public static void sum()
            {
                int sum = 1 + 2;
                Console.WriteLine(sum);
            }
            public static void sum(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine(sum);
            }
            public static void sum(int a, int b, int c)
            {
                int sum = a + b + c;
                Console.WriteLine(sum);
            }
            public static void sum(string a, string b)
            {
                int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
                Console.WriteLine(sum);
            }
            public static void Main1()
            {
                sum();
                sum(1, 2, 3);
                sum(1, 2);
                sum("1", "2");
            }
        }

    }

