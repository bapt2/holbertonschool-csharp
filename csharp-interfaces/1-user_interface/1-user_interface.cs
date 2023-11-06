using System;

public abstract class Base
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
    void Interact();
}

public interface IBreakable
{
     int durability {get; set;}

    /// <summary>
    /// public void Break
    /// </summary>
    void Break();
}

public interface ICollectable
{
     bool isCollected {get; set;}

    void Collect();
}

public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {get; set;}


    public void Interact()
    {
        throw new NotImplementedException();
    }

    public void Break()
    {
        throw new NotImplementedException();
    }

    public void Collect()
    {
        throw new NotImplementedException();
    }
}