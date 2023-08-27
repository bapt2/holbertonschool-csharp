using System;

class Obj
{
    /// <summary>
    /// public static bool IsOnlyASubclass
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType)) { return true; }
        return false;
    }
}
