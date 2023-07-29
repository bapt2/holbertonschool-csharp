using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 26; i++)
        {
            if (i != 6 && i != 17)
            {
                Console.Write(Convert.ToChar(i + (int)'a'));
            }
        }
    }
}
