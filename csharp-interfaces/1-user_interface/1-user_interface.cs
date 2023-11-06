using System;

abstract class Base
{
    public string name {get; set;}

    /// <summary>
    /// public override string ToString
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType());
    }
}

public interface IInteractive
{
    /// <summary>
    /// public void Interact
    /// </summary>
    public void Interact()
    {

    }
}

public interface IBreakable
{
    public int durability {get; set;}

    /// <summary>
    /// public void Break
    /// </summary>
    public void Break()
    {

    }
}

public interface ICollectable
{
    public bool isCollected {get; set;}

    public void Collect()
    {

    }
}

public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    
}