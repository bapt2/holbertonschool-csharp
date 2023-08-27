using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

class Obj
{
    /// <summary>
    /// public static void Print
    /// </summary>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        TypeInfo tI = t.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = tI.GetProperties();
        IEnumerable<MethodInfo> mList = tI.GetMethods();

        Console.WriteLine("{0} Properties:", t.Name);

        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}
