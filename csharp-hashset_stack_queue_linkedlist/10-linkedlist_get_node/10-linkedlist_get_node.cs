using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; current != null; i++)
        {
            current = current.Next;
            if (i == n -1)
            {
                return current.Value;
            }
        }
        return 0;
    }
}
