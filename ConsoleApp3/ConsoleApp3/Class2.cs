using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
       //   Operator Overloading Multiplication Operation
        class Cal
        {
            public int Number1, Number2;

            public Cal(int num1, int num2)
            {
                Number1 = num1;
                Number2 = num2;
            }

            public void Print()
            {
                Console.WriteLine("Number 1=" + Number1);
                Console.WriteLine("Number 2=" + Number2);
            }

            public static Cal operator *(Cal c1, Cal c2)
            {
                Cal c3 = new Cal(0, 0);
                c3.Number1 = c1.Number1 * c2.Number1;
                c3.Number2 = c1.Number2 * c2.Number2;
                return c3;
            }
        }
        class Class2
        {
            public static void Main3()
            {
                Cal cal1 = new Cal(2, 2);
                Cal cal2 = new Cal(2, 3);
                Cal cal3 = new Cal(0, 0);
                cal3 = cal1 * cal2;
                cal3.Print();
            }
        }
    }

