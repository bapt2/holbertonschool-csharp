using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; current != null; i++)
        {
            if (n < i)
            {
                return 0;
            }
            if (i == n)
            {
                return current.Value;
            }
            current = current.Next;
        }
        return 0;
    }
}
