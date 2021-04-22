﻿using Common;
using System;
using System.Threading.Tasks;

namespace V1.TaskMulth._03
{
    /// <summary>
    /// Write a program, which multiplies two matrices and uses class Parallel. 
    /// </summary>
    class Program
    {
        private static readonly Random Random = new Random();

        static void Main()
        {
            var r1 = Helper.DigitsInput("Matrix #1 rows count:");
            var c1 = Helper.DigitsInput("Matrix #1 columns count:");
            var matrix1 = BuildRandomIntMatrix(r1, c1);

            var r2 = Helper.DigitsInput($"Matrix #2 rows count:");
            var c2 = Helper.DigitsInput($"Matrix #2 columns count:");
            var matrix2 = BuildRandomIntMatrix(r2, c2);

            var result = MultiplyMatrices(matrix1, matrix2);
            PrintMatrixToScreen(result);

            throw new NotImplementedException();


            // ReSharper disable once FunctionNeverReturns
        }



        private static int[,] BuildRandomIntMatrix(int rows, int columns)
        {
            var result = new int[rows, columns];
            for (var i = 0; i < rows; i++)
                for (var j = 0; j < columns; j++)
                    result[i, j] = Random.Next(10);

            return result;
        }

        private static void PrintMatrixToScreen(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]}    ");

                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        private static int[,] MultiplyMatrices(params int[][,] matrices)
        {
            throw new NotImplementedException();
        }
    }
}
