﻿using System;
using System.Collections.Generic;
using System.Collections;

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

/// <summary>
/// public class Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{

    /// <summary>
    /// public int durability
    /// </summary>
    public int durability {get; set;}

    /// <summary>
    /// public bool isQuestItem
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// public Decoration
    /// </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            Console.WriteLine("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// public void Interact
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
            return;
        }
        if (isQuestItem == true)
        {
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        }
        else
        {
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
        }
    }

    /// <summary>
    /// public void Break
    /// </summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", name);
        }
        else
        {
            Console.WriteLine("The {0} is already broken.", name);
        }
    } 
}

/// <summary>
/// public class Key
/// </summary>
public class Key: Base, ICollectable
{


    /// <summary>
    /// public bool isCollected
    /// </summary>
    public bool isCollected {get; set;}

    /// <summary>
    /// public Key
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isCollected"></param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// public void Collect
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
            return;
        }
        if (isCollected == true)
        {
            Console.WriteLine("You have already picked up the {0}.", name);
            return;
        }
    }
}

/// <summary>
/// public class Objs
/// </summary>
public class Objs<T>: IEnumerable<T>
{
    List<T> objs = new List<T>();

    /// <summary>
    /// public void Add
    /// </summary>
    /// <param name="obj"></param>
    public void Add(T obj)
    {
        objs.Add(obj);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// public IEnumerator GetEnumerator
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
        return objs.GetEnumerator();
    } 
}