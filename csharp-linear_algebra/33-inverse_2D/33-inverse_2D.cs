using System;

class MatrixMath
{
    /// <summary>
    /// public static double[,] Inverse2D
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] {{-1}};
        }

        double factor = ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        if (factor == 0)
        {
            return new double[,] {{-1}};
        }
        factor = 1 / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        double[,] result = new double[2, 2];

        result[0, 0] = Math.Round(matrix[1, 1] * factor, 2);
        result[0, 1] = Math.Round(-matrix[0, 1] * factor, 2);
        result[1, 0] = Math.Round(-matrix[1, 0] * factor, 2);
        result[1, 1] = Math.Round(matrix[0, 0] * factor, 2);
        return result;
    }
}
