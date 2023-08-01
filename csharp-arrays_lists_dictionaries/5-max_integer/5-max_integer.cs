using System;
using System.Collections.Generic;
    class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if(myList.Count == 0)
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            myList.Sort();
            int i = 0;
            for (; i < myList.Count; i++)
            {
                if(i == myList.Count - 1)
                {
                    return myList[i];
                }
            }
            return i;
        }
    }
