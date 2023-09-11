using System;

class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == 0 || matrix2.Length == 0)
        {
            double[,] error = new double[,] {{ -1 }};
            return error;
        }
        int column = matrix1.GetLength(0);
        int row = matrix1.GetLength(1);
        double[,] result = new double[column, row];
        
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
