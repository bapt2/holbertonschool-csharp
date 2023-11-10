using System;

/// <summary> public class Player </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    string status;

    /// <summary> public event EventHandler </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

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
        status = String.Format("{0} is ready to go!", name);
        HPCheck = CheckStatus;
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
        if (damage > hp)
        {
            hp = 0;
        }
        else
        {
            ValidateHP(hp - damage);
        }
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
        ValidateHP(hp + heal);
    }

    /// <summary> public void HealDamage </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0 )
        {
            newHp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else 
        {
            hp = newHp;
        }
        HPCheck(this, new CurrentHPArgs(hp));
    }

    /// <summary> public float ApplyModifier </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue *= 0.5f;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else
        {
            return baseValue *= 1.5f;
        }
    }

    

    /// <summary> private void CheckStatus </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = String.Format("{0} is in perfect health!", name);
        }
        else if (e.currentHp >= (maxHp / 2) && e.currentHp < maxHp)
        {
            status = String.Format("{0} is doing well!", name);
        }
        else if (e.currentHp >= (maxHp / 4) && e.currentHp > (maxHp / 2))
        {
            status = String.Format("{0}  isn't doing too great...", name);
        }
        else if (e.currentHp > 0 && e.currentHp < (maxHp / 4))
        {
            status = String.Format("{0} needs help!", name);
        }
        else if (e.currentHp == 0)
        {
            status = String.Format("{0} is knocked out!", name);
        }
        Console.WriteLine(status);
    }

}

/// <summary> public enum Modifier </summary>
public enum Modifier
{
    /// <summary> Weak </summary>
    Weak,

    /// <summary> Base </summary>
    Base,

    /// <summary> Strong </summary>
    Strong
};

/// <summary> public delegate float CalculateModifier </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> public class CurrentHPArgs </summary>
public class CurrentHPArgs: EventArgs
{
    /// <summary> public float currentHp </summary>
    public float currentHp {get;set;}


    /// <summary> public CurrentHPArgs </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}