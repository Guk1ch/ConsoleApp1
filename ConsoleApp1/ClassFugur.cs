using System;

class ClassFugur
{
    static void Main()
    {
        Dot II = new Line(2, 1, 5, 6);
        II.Draw();
    }
}

public class Dot
{
    protected int x;
    protected int y;

    public Dot(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
    public virtual void Draw()
    { }
}

public class Line : Dot
{
    protected int x1;
    protected int y1;

    public Line(int newX, int newY, int newX1, int newY1) : base(newX, newY)
    {
        x1 = newX1;
        y1 = newY1;
    }

    public override void Draw()
    {
        Console.WriteLine("Линия с первой точкой (" + x + ", " + y + ") и второй точкой (" + x1 + ", " + y1 + ")");
    }
}

public class Circle : Dot
{
    protected int r;

    public Circle(int newX, int newY, int newR) : base(newX, newY)
    {
        r = newR;
    }

    public override void Draw()
    {
        Console.WriteLine("Окружность с центром в точке (" + x + ", " + y + ") и радиусом = " + r);
    }
}
