using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        bool isPresent = false;
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        for (int i = 0; i < aStack.Count; i++)
        {
            count += 1;
            if (i == aStack.Count - 1)
            {
                Console.WriteLine("Number of item: {0}", count);
                Console.WriteLine("Top item: {0}", aStack.Peek());
            }
        }
        if (aStack.Contains(search))
        {
            isPresent = true;
            Console.WriteLine("Stack contains \"{0}\": {1}", search, isPresent);
            while (aStack.Count > 0)
            {
                string currentItem = aStack.Peek();
                aStack.Pop();
                if (currentItem == search)
                {
                    break;
                }
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}