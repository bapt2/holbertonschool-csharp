﻿using System;

class MatrixMath
{
    /// <summary>
    /// public static double[,] Inverse2D
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] result = new double[2, 2];
        double factor = 1 / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 || factor == 0)
        {
            return new double[,] {{-1}};
        }

        result[0, 0] = Math.Round(matrix[1, 1] * factor, 2);
        result[0, 1] = Math.Round(-matrix[0, 1] * factor, 2);
        result[1, 0] = Math.Round(-matrix[1, 0] * factor, 2);
        result[1, 1] = Math.Round(matrix[0, 0] * factor, 2);
        return result;
    }
}