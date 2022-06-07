using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class8
    {
        static void Main9(string[] args)
        {
            // Program to Find second highest number from an array
            int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            Array.Sort(array);             //sorting array  
            Array.Reverse(array);          // Reverse Sorting array value  
            Console.WriteLine("Second Highest Number In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " "); // Array values  

            }

            /*//Write a program in C# Sharp to count a total number of duplicate elements in an array.
           int[] arr = new int[100];
           int i, j, num, count = 0;

           //Reads size of the array
           Console.WriteLine("Enter size of the array: ");
           num = Convert.ToInt32(Console.ReadLine());

           //Reads elements in array
           Console.WriteLine("Enter elements in the array: ");
           for (i = 0; i < num; i++)
           {
               arr[i] = Convert.ToInt32(Console.ReadLine());
           }

           //Find all duplicate elements in array
           for (i = 0; i < num; i++)
           {
               for (j = i + 1; j < num; j++)
               {
                   // If duplicate element found then increment count by 1
                   if (arr[i] == arr[j])
                   {
                       count++;
                       break;
                   }
               }
           }

           Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
           Console.ReadLine();
       }  */

        }
    }
}
