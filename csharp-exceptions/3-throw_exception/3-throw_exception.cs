using System;

class Except
{
    public static void Throw()
    {
        throw new DivideByZeroException("Cannot divide by zero");
    }
}
