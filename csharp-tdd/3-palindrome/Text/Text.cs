using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// public class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// public static bool IsPalindrome
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return true;
            }
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            string reverseStr = new string(reverse);
            if (reverseStr == s)
            {
                return true;
            }
            return false;
        }
    }
}
