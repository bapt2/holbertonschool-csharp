using System;
using System.Collections.Generic;

    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
            List<bool> isDivisibleBy2 = new List<bool>();
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] % 2 == 0)
                {
                    isDivisibleBy2.Add(true);
                }
                else
                {
                    isDivisibleBy2.Add(false);
                }
            }
            return isDivisibleBy2;
        }
    }
