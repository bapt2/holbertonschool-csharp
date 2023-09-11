using System;


class MatrixMath
{
    /// <summary>
    /// public static double[,] MultiplyScalar
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length != 4 || matrix.Length != 9)
        {
            double[,] error = new double[,] { { -1 } };
            return error;
        }
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] * scalar; 
            }
        }
        return result;
    }
}

