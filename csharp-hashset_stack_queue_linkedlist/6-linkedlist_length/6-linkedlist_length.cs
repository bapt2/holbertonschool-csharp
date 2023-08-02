using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        LinkedListNode<int> length = myLList.First;
        int count = 0;
        for (int i = 1;  length!= null; i++)
        {
            length = length.Next;
            count = i;
        }
        return count;
    }
}

