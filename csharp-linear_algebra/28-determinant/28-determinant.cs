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

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (direction == matrix.Length == 4)
                {
                    result = (matrix[i, 0] * matrix[j, 0]) - (matrix[i, 1] * matrix[j, 1]);
                    result[i, 1] = matrix[i, 1];
                }

            }
        }
        return result;
    }
}
