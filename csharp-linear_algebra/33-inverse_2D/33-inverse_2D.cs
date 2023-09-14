using System;

class MatrixMath
{
    /// <summary>
    /// public static double[,] Inverse2D
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.Length != 4)
        {
            return new double[,] {{-1}};
        }
        double[,] result = new double[2, 2];
        double factor = 0;
        factor =  1 / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        result[0, 0] = result[0, 0] * factor;
        result[0, 1] = result[0, 1] * factor;
        result[1, 0] = result[1, 0] * factor;
        result[1, 1] = result[1, 1] * factor;
        return result;
    }
}
