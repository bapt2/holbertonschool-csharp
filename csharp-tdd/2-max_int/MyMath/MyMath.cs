using System;
using System.Collection;

namespace MyMath
{
    /// <summary>
    /// public class Operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// public static int Max(List<int> nums)
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == null)
            {
                return 0;
            }
            nums.Sort();
            nums.Reverse();
            return nums[0];
        }
    }
}
