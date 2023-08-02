using System;
using System.Collections.Generic;
using System.Linq;
    class List
    {
        public static int Sum(List<int> myList)
        {
            myList = myList.Distinct().ToList();
            int result = 0;
            foreach (int unique in myList)
            {
                result += unique;
            }
            return result;
        }
    }

