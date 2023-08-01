using System;


    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = new int[5, 5] {{0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}};
            square[2, 2] = 1;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    if (j == square.GetLength(0))
                    {
                        Console.Write(square.GetValue(i, j));
                    }
                    else 
                    {
                        Console.Write("{0} ", square.GetValue(i, j));
                    }
                }
                Console.WriteLine();
            }
        }
    }
