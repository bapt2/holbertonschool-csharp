using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// public static bool IsOfTypeInt
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int) { return true; }
        return false;
    }
}

