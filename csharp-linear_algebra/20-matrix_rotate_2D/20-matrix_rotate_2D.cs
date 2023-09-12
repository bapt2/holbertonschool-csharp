using System;

    class MatrixMath
    {
        /// <summary>
        /// public static double[,] Rotate2D
        /// </summary>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            double[,] error = {{ -1 }};
            if (matrix.Length == 0)
            {
                return error;
            }

            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)]
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] * angle;
                }
            }
            return result;
        }
    }
