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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (direction == 'x')
                    {
                        result[i, j] = matrix[i, k] + (factor * matrix[k, j]);
                    }
                    else
                    {
                        result[i, j] = matrix[k, j] + (factor * matrix[i, k]);
                    }
                }
            }
        }
        return result;
    }
}
