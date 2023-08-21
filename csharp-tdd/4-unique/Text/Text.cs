using System;

namespace Text
{
    /// <summary>
    /// public class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// public static int UniqueChar
        /// </summary>
        public static int UniqueChar(string s)
        {
            int index;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                index = 0;
                for (int j = 0; j < len; j++)
                {
                    if (s[i] == s[j] && i != j)
                    {
                        index += 1;
                    }
                }
                if (index == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
