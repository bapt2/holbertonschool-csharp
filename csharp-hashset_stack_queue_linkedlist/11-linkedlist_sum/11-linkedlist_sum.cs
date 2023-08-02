using System;
using System.Collections.Generic;

    class LList
    {
        public static int Sum(LinkedList<int> myLList)
        {
            int result = 0;
            LinkedListNode<int> current = myLList.First;
            for (int i = 0; current != null; i++)
            {
                result += current.Value;
                current = current.Next;
            }
            return result;
        }
    }

