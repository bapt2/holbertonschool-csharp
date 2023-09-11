using System;


class MatrixMath
{
    /// <summary>
    /// public static double[,] Add
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length < 2 || matrix1.Length > 3 || matrix2.Length < 2 || matrix2.Length > 3 || matrix1.Length != matrix2.Length)
        {
            double[,] error = new double[,] {{-1}};
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
