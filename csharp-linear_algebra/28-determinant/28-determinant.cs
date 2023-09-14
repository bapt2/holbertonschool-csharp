using System;


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

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix.Length == 4)
            {
                result = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            }
        }
        return result;
    }
}
