using System;
using System.Linq;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string names, float ages, string owners, Rating ratings)
    {
        name = names;
        age = ages;
        owner = owners;
        rating = ratings;

    }

    public override string ToString()
    {
        return string.Format("Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }
}
