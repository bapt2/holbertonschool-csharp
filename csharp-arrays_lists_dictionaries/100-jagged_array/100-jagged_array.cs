﻿using System;


class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][]{
        new int[] { 0, 1, 2, 3 },
        new int[] { 0, 1, 2, 3, 4, 5, 6 },
        new int[] { 0, 1 }
        };

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Element({0}): ", i);
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (j == jaggedArray[i].Length - 1)
                {
                    Console.Write("{0}", jaggedArray[i][j]);
                }
                else
                {
                    Console.Write("{0} ", jaggedArray[i][j]);
                }
            }
            Console.WriteLine();
        }
    }
}

