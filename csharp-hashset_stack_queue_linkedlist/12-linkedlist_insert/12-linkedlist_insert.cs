using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; current != null; i++)
        {
            if (n < current.Value)
            {
                myLList.AddBefore(current, n);
                return current;
            }
            if (current.Next == null)
            {
                myLList.AddAfter(current, n);
                return current;
            }
            else
            {
                current = current.Next;
            }
        }
        return current;
    }
}
