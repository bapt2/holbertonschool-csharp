using System;

namespace Text
{
    /// <summary>
    /// public class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// public static int CamelCase
        /// </summary>
        public static int CamelCase(string s)
        {
            int word = 1;
            if (s.Length == 0)
            {
                word = 0;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if(Char.IsUpper(s[i]))
                {
                    word += 1;
                }
            }
            return word;
        }
    }
}
