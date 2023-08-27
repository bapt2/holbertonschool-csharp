using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// public static bool IsInstanceOfArray
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj)) { return true; }
        return false;
    }
}
