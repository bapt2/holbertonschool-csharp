﻿using System;


class MatrixMath
{
    /// <summary>
    /// public static double Determinant
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.Length != 4 && matrix.Length != 9)
        {
            return -1;
        }
        double result = 0;
        double first = 0;
        double second = 0;
        double third = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix.Length == 4)
            {
                result = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
            }
            else
            {
                first = (matrix[0, 0]) * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2]) * matrix[2, 1]);
                Console.WriteLine(first);

                second = (matrix[0, 1]) * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2]) * matrix[2, 0]);
                Console.WriteLine(second);

                third = (matrix[0, 2]) * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1]) * matrix[2, 0]);
                Console.WriteLine(third);

                result = Math.Round(first - second + third, 2);
            }
        }
        return result;
    }
}