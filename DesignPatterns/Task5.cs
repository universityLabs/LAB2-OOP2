namespace DesignPatterns;

internal interface IFigure
{
    IFigure Clone();
    void GetInfo();
}

internal class Rectangle : IFigure
{
    int width;
    int height;
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public IFigure Clone()
    {
        return new Rectangle(this.width, this.height);
    }
    public void GetInfo()
    {
        Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
    }
}

internal class Circle : IFigure
{
    int radius;
    public Circle(int r)
    {
        radius = r;
    }
    public IFigure Clone()
    {
        return new Circle(this.radius);
    }
    public void GetInfo()
    {
        Console.WriteLine("Круг радіусом {0}", radius);
    }
}

internal class Triangle : IFigure
{
    int x1;
    int x2;
    int x3;
    public Triangle(int a1, int a2, int a3)
    {
        x1 = a1;
        x2 = a2;
        x3 = a3;
    }
    public IFigure Clone()
    {
        return new Triangle(this.x1, this.x2, this.x3);
    }

    public void GetInfo()
    {
        Console.WriteLine("side a1: {0}, side a2: {1}, side a3: {2}", x1, x2, x3);
    }
}
