using System;
using System.Collections.Generic;

namespace Lesson9
{
    internal class Lesson9
    {
        public static void Main(string[] args)
        {
            //В этом уроке не будет много писанины.
            //Для начала нужно ознакомиться с многомерными массивами по ссылке
            //https://professorweb.ru/my/csharp/charp_theory/level4/4_2.php

            int[,] matrix2x2 = new int[2, 2];
            matrix2x2[0, 0] = 2;
            matrix2x2[0, 1] = 12;
            matrix2x2[1, 0] = 22;
            matrix2x2[1, 1] = 32;
          //  PrintMatrix2x2(matrix2x2);

            int[,] matrix3x3 = new int[3, 3];
            matrix3x3[0, 0] = 3;
            matrix3x3[0, 1] = 13;
            matrix3x3[0, 2] = 23;
            matrix3x3[1, 0] = 33;
            matrix3x3[1, 1] = 43;
            matrix3x3[1, 2] = 53;
            matrix3x3[2, 0] = 63;
            matrix3x3[2, 1] = 73;
            matrix3x3[2, 2] = 83;
          //  PrintMatrix3x3(matrix3x3);

           // matrix2x2 = TakeMatrix2x2();
            //PrintMatrix2x2(matrix2x2);

           // matrix3x3 = TakeMatrix3x3();
           // PrintMatrix3x3(matrix3x3);
            PrintMatrix(matrix2x2);
            PrintMatrix(matrix3x3);
            int[,] matrix= TakeMatrix();
            PrintMatrix(matrix);

        }

        //Распечатывает матрицу 2 на 2
        static void PrintMatrix2x2(int[,] matrix2x2)
        {
            for (int i=0; i<2; i++ )
                {
                    for (int j=0; j<2; j++)
                        {
                            Console.Write(matrix2x2[i, j]+" ");
                        }
                 Console.WriteLine(); 
                 }

                }

        //Распечатывает матрицу 3 на 3
        static void PrintMatrix3x3(int[,] matrix3x3)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                        Console.Write(matrix3x3[i, j] +" ");
                }
                Console.WriteLine();
            }

        }

        //Возвращает матрицу 2 на 2 заполненую пользователем
        static int[,] TakeMatrix2x2()
        {
            int[,] matrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("введите число " + (j + 1));
                    matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                }


            }
            return matrix;
        }

        //Возвращает матрицу 3 на 3 заполненую пользователем
        private static int[,] TakeMatrix3x3()
        {
            int[,] matrix = new int[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("введите число " + (j + 1));
                    matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                }

            }
            
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int lenght = matrix.Length;
            double sqt = Math.Sqrt(lenght);
            for (int i = 0; i < sqt; i++)
            {
                for (int j = 0; j < sqt; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] TakeMatrix()
        {
            Console.WriteLine("введите размер");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix= new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine("введите число" + (i+j));
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        return matrix;
    }
    }
}