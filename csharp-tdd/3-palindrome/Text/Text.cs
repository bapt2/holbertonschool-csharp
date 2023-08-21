using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            s = Regex.Replace(s, @"[^\w\d]", "");
            string reverse = string.Join("", s.Reverse());

            if (reverse.ToLower() == s.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}
