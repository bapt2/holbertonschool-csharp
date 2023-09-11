using System;


class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double result = 0;
        if (vector.Length > 3 || vector.Length < 2)
        {
            return -1;
        }
        if (vector.Length == 3)
        {
            result = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
            return Math.Round(result, 2); 
        }
        else
        {
            result = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
            return Math.Round(result, 2); 
        }
    }
}