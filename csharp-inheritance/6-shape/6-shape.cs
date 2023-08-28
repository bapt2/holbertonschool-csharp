using System;


class Shape
{
    /// <summary>
    /// public virtual int Area
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    int width;
    int height;

    public int Width
    {
        get => width
        set
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0")
            }
            set = width
        }
    }
    public int Height
    {
        get => height
        set
        {
            if (width <= 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0")
            }
            set = height
        }
    }
}