using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        LinkedListNode<int> tmp = myLList.First;
        for (int i = 0; tmp != null; i++)
        {
            if (tmp.Value == value)
            {
                return i;
            }
            tmp = tmp.Next;
        }
        return -1;
    }
}

