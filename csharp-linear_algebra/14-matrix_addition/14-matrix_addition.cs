﻿using System;


class MatrixMath
{
    /// <summary>
    /// public static double[,] Add
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length != matrix2.Length || matrix1.Length < 4)
        {
            double[,] error = new double[,] { { -1 } };
            return error;
        }
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }
}
