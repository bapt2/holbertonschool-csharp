using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] error = { { -1 } };
        if (matrix.Length == 0 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return error;
        }
        if (direction != 'x' && direction != 'y')
        {
            return error;
        }
        double[,] result = new double[2, 2];
        double[,] copy = matrix;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (direction == 'x')
            {
                result[i, 0] = matrix[i, 0] + (factor * matrix[i, 1]);
                result[i, 1] = matrix[i, 1];
            }
            else
            {
                result[i, 1] = matrix[i, 1] + (factor * matrix[i, 0]);
                result[i, 0] = matrix[i, 0];
            }
        }
        return result;
    }
}
