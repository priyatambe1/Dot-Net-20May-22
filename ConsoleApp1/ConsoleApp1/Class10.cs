using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class10
    {
        static void Main11(string[] args)
        {
            //Write a program in C# Sharp to print all unique elements in an array.
            /* int[] arr = new int[100]; ;
             int i, j, k, size, isUnique;

             //Reads size of the array
             Console.WriteLine("Enter size of the array: ");
             size = Convert.ToInt32(Console.ReadLine());
             //Reads elements in array
             Console.WriteLine("Enter elements in the array: ");
             for (i = 0; i < size; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             //Removing all duplicate elements from the array

             for (i = 0; i < size; i++)
             {
                 // Assuming  cuurent element is unique 
                 isUnique = 1;

                 for (j = i + 1; j < size; j++)
                 {

                     //If any duplicate element is found

                     if (arr[i] == arr[j])
                     {
                         // Removing duplicate element
                         for (k = j; k < size - 1; k++)
                         {
                             arr[k] = arr[k + 1];
                         }

                         size--;
                         j--;
                         isUnique = 0;
                     }
                 }


             If array element is not unique
             then also remove the current element

                 if (isUnique != 1)
                 {
                     for (j = i; j < size - 1; j++)
                     {
                         arr[j] = arr[j + 1];
                     }

                     size--;
                     i--;
                 }
             }

             //Printing all unique elements in array
             Console.WriteLine("All unique elements in the array are: ");
             for (i = 0; i < size; i++)
             {
                 Console.WriteLine(arr[i] + "\t");
             }
             Console.ReadLine();  */
            
            
            // Jagged Array
            int[][] jaggged_array = new int[][]
                {
                new int[] { 1,2},
                new int[] { 1,2,3,4,5},
                new int[] { 1,2,3,4,5,6,7,8},
                new int[] { 1,2,3,4,5,6,7,8,9,10}
                };

            for (int i = 0; i < jaggged_array.Length; i++)
            {
                for (int j = 0; j < jaggged_array[i].Length; j++)
                {
                    Console.Write(jaggged_array[i][j]);
                }
                Console.WriteLine();
            }

        }


    }
}
