using System;

class Queue<T>
{
    Node head;
    Node tail;
    int count;

    /// <summary>
    /// public Type CheckType()
    /// </summary>
    /// <returns></returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// public class Node
    /// </summary>
    public class Node
    {
        T value;
        public Node next {get; set;} = null;

        /// <summary>
        /// public Node(T Value)
        /// </summary>
        /// <param name="Value"></param>
        public Node(T Value)
        {
            value = Value;
        }
    }

    /// <summary>
    /// public void EnQueue
    /// </summary>
    /// <param name="Value"></param>
    public void Enqueue(T Value)
    {
        Node newNode = new Node(Value);

        if (head == null)
        {
            tail = head = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// public int Count
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return count;
    }
}
