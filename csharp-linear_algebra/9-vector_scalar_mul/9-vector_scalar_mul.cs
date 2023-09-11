using System;


class VectorMath
{
    /// <summary>
    /// public static double[] Multiply
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            double[] error = new double[] {-1};
            return error;
        }
        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }
        return result;
    }
}

