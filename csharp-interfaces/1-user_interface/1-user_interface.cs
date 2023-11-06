using System;

/// <summary>
/// public abstract class Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// public string name
    /// </summary>
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

/// <summary>
/// public interface IInteractive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// public void Interact
    /// </summary>
    void Interact();
}


/// <summary>
/// public interface IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// int durability
    /// </summary>
     int durability {get; set;}

    /// <summary>
    /// public void Break
    /// </summary>
    void Break();
}

/// <summary>
/// public interface ICollectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// bool isCollected
    /// </summary>
    bool isCollected {get; set;}
    
    /// <summary>
    /// Collect
    /// </summary>
    void Collect();
}

/// <summary>
/// public class TestObject: Base, IInteractive, IBreakable, ICollectable
/// </summary>
public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// public int durability
    /// </summary>
    public int durability {get; set;}

    /// <summary>
    /// public bool isCollected
    /// </summary>
    public bool isCollected {get; set;}

    /// <summary>
    /// public void Interact
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// public void Break
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// public void Collect
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}