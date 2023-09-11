using System;

class MatrixMath
{
    /// <summary>
    /// public static double[,] Multiply
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] error = new double[,] { { -1 } };
        if (matrix1.Length == 0 || matrix2.Length == 0)
        {
            return error;
        }
        int column = matrix1.GetLength(1);
        int row = matrix2.GetLength(0);
        if (row != column)
        {
            return error;
        }
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
