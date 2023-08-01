using System;


    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = new int[5,5];
            for (int i = 0; i < square.Length; i++)
            {
                if (i == 5 || i == 10 || i == 15 || i == 20 || i == 25)
                {
                    Console.WriteLine();
                }
                if (i == 12)
                {
                Console.Write("1");
                }
                else
                {
                Console.Write("0");
                }
            }
            Console.WriteLine();

        }
    }

