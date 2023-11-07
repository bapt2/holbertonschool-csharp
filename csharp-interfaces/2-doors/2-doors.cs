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
public class Door: Base, IInteractive
{
    /// <summary>
    /// public Door
    /// </summary>
    /// <param name="name"></param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// public void Interact
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }

    
}