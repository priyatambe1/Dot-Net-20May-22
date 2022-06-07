using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main4(string[] args)
        {
              //Program to create calculator where u will ask user what he want to do(add,Sub,Multiplication,Division)
 double n1, n2, result = 0;
 Console.Write("Write 1st Number:");
 n1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Write 2nd Number:");
 n2 = Convert.ToDouble(Console.ReadLine()); 

 Console.Write("Enter an Operator(+, -, *, /):");
 char operand = Console.ReadKey().KeyChar;
 Console.WriteLine();


 switch (operand)
 {
     case '+':
         result = n1 + n2;
         break;
     case '-':
         result = n1 - n2;
         break;
     case '*':
         result = n1 * n2;
         break;
     case '/':
         result = n1 / n2;
         break;

     default:
         Console.WriteLine("Enter a Valid Choice");
         break;
 }
 Console.WriteLine(n1 + "" + operand + "" + n2 + ":" + result);
 Console.ReadLine(); 

}
}
}
