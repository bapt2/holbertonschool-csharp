using System;
using System.Collections.Generic;
    class List
    {
        public static List<int> CreatePrint(int size)
        {
            List<int> listInt = new List<int>();
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            for (int i = 0; i < size; i++)
            {
                listInt.Add(i);
                if (i == size - 1)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            return listInt;
        }
    }
