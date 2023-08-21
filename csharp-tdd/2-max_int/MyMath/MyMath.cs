using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// public class Operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// public static int Max
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count < 1)
            {
                return 0;
            }
            nums.Sort();
            nums.Reverse();
            return nums[0];
        }
    }
}
