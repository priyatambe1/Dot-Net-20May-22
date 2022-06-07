using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class9
    {
        static void Main10(string[] args)
        {
            /* // Multiplication Of Matrix
                int i = 0;
                    int j = 0;

                    int row = 2;
                    int col = 2;

                    int[,] Matrix1 = new int[row, col];
                    int[,] Matrix2 = new int[row, col];
                    int[,] Matrix3 = new int[row, col];

                    Console.Write("Enter the elements of matrix1: ");
                    for (i = 0; i < row; i++)
                    {
                        for (j = 0; j < col; j++)
                        {
                            Matrix1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.Write("Enter the elements of matrix2: ");
                    for (i = 0; i < row; i++)
                    {
                        for (j = 0; j < col; j++)
                        {
                            Matrix2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }


                    for (i = 0; i < row; i++)
                    {
                        for (j = 0; j < col; j++)
                        {
                            Matrix3[i, j] = 0;
                            for (int k = 0; k < 2; k++)
                            {
                                Matrix3[i, j] += Matrix1[i, k] * Matrix2[k, j];
                            }
                        }
                    }


                    Console.WriteLine("\nMatrix1: ");
                    for (i = 0; i < row; i++)
                    {
                        for (j = 0; j < col; j++)
                        {
                            Console.Write(Matrix1[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nMatrix2: ");
                    for (i = 0; i < row; i++)
                    {
                        for (j = 0; j < col; j++)
                        {
                            Console.Write(Matrix2[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nMatrix3: ");
                    for (i = 0; i < row; i++)
                    {
                        for (j = 0; j < col; j++)
                        {
                            Console.Write(Matrix3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }   */


            // Transpose Of Matrix
            int i, j, m, n;
          int[,] arr1 = new int[30, 30];
          int[,] arr2 = new int[30, 30];

          Console.Write("\nEnter the number of rows and columns of the matrix :\n");
          Console.Write("Rows entered = ");
          m = Convert.ToInt32(Console.ReadLine());

          Console.Write("Columns entered = ");
          n = Convert.ToInt32(Console.ReadLine());

          Console.Write("Set elements in the matrix...\n");
          for (i = 0; i < m; i++)
          {
              for (j = 0; j < n; j++)
              {
                  Console.Write("\n [{0}],[{1}] : ", i, j);
                  arr1[i, j] = Convert.ToInt32(Console.ReadLine());
              }
          }

          Console.Write("\n\nMatrix before Transpose:\n");
          for (i = 0; i < m; i++)
          {
              Console.Write("\n");
              for (j = 0; j < n; j++)
                  Console.Write("{0}\t", arr1[i, j]);
          }

          for (i = 0; i < m; i++)
          {
              for (j = 0; j < n; j++)
              {

                  arr2[j, i] = arr1[i, j];
              }
          }

          Console.Write("\n\nMatrix after Transpose: ");
          for (i = 0; i < m; i++)
          {
              Console.Write("\n");
              for (j = 0; j < n; j++)
              {
                  Console.Write("{0}\t", arr2[i, j]);
              }
          }
          Console.Write("\n\n");
      } 
    }
}
