using System;


class MatrixMath
{
    /// <summary>
    /// public static double[,] Transpose
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.GetLength(0) == 0)
        {
            return new double[0, 0];
        }

        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }
}
