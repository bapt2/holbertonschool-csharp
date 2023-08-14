using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            try
            {
                count += 1;
                Console.WriteLine(myList[i]);
            }
            catch (Exception)
            {
            }
        }
        return count;
    }
}
