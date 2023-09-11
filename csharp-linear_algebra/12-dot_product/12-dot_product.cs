using System;


class VectorMath
{
    /// <summary>
    /// public static double DotProduct
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double result = 0;

        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3 || vector1.Length != vector2.Length)
        {
            return -1;
        }
        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }
        return result;
    }
}
