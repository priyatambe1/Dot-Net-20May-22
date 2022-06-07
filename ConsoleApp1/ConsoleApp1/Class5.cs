using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class5
    {
        static void Main6(string[] args)
        {
               int a, b;
                Console.WriteLine("Enter Number");
                int n = Convert.ToInt32(Console.ReadLine());

                for (a = 1; a <= n; a++)
                {
                    for (b = 1; b <= n; b++)
                    {
                        if (a == 1 || a == n || b == 1 || b == n || a == b || b == (n - a + 1))

                            Console.Write("*");
                        else

                            Console.Write(" ");
                    }

                    Console.WriteLine();

                }

            }
        }
    }

