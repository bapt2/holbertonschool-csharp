using System;

class MatrixMath
{
    /// <summary>
    /// public static double[,] Multiply
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == 0 || matrix2.Length == 0)
        {
            double[,] error = new double[,] {{ -1 }};
            return error;
        }
        int row = matrix2.GetLength(0);
        int column = matrix1.GetLength(1);
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < column; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
