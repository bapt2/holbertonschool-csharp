using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] error = { { -1 } };
        if (matrix.Length == 0 || direction != 'x' && direction != 'y' || matrix.GetLength(0) != 2 || matrix.GetLength(1))
        {
            return error;
        }
        double[,] result = new double[2, 2];
        if (direction == 'x')
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (direction == 'x')
                        {
                            result[i, j] += matrix[i, k] + factor * matrix[k, j];
                        }
                        if (direction == 'y')
                        {
                            result[i, j] += matrix[k, j] + factor * matrix[i, k];
                        }
                    }
                }
            }
        }
        return result;
    }
}
