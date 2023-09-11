using System;

class VectorMath
{
    /// <summary>
    /// public static double[] Add
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];

        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3 || vector1.Length != vector2.Length)
        {
            double[] error = new double[] {-1};
            return error;
        }

        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}

