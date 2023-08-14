using System;

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
}
