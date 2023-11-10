using System;

/// <summary> public class Player </summary>
public class Player
{
    /// <summary> public string name </summary>
    string name {get;set;}

    /// <summary> public float maxHp </summary>
    float maxHp {get;set;}

    /// <summary> public float hp </summary>
    float hp {get;set;}

    /// <summary> public Player </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        hp = maxHp;
    }

    /// <summary> public void PrintHealth </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
    
    /// <summary> public delegate CalculateHealth </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public delegate void CalculateHealth(float amount);

    /// <summary> public void TakeDamage </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine("{0} takes 0 damage!", name);
            return;
        }

        Console.WriteLine("{0} takes {1} damage!", name, damage);
    }

    /// <summary> public void HealDamage </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine("{0} heals 0 HP!", name);
            return;
        }

        Console.WriteLine("{0} heals {1} HP!", name, heal);
    }

}
