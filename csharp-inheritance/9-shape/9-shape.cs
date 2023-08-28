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
        get => width;
        set
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    public int Height
    {
        get => height;
        set
        {
            if (height < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
    public override int Area()
    {
        return width * height;
    }
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

class Square : Rectangle
{
    int size;

    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Height = value;
            Width = value;

        }
    }
    public override string ToString()
    {
        return string.Format("[Square] {0} / {0}", size);
    }
}