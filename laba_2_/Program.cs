using System;


public class point
{

    private double x, y;
    private string colour;

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }
    public string Colour
    {
        get { return colour; }
        set { colour = value; }
    }

    public bool isAtBegining
    {
        get { return x == 0 && y == 0; }
    }

    public double scalar
    {
        set
        {
            x *= value;
            y *= value;
        }
    }

    public point(double x, double y)
    {
        this.x = x;
        this.y = y;
        this.colour = colour;
    }



    public point()
    {
        this.x = 0;
        this.y = 0;
    }

    // Метод для виведення координат точки .
    public void showCoord()
    {
        Console.WriteLine($"координати точки: ({x}, {y})");
    }

    public void showColour()
    {
        Console.WriteLine($"колір точки: {colour}");
    }

    // Метод для обчислення відстані від точки до початку координат.
    public double DistanceFromBegining()
    {
        return Math.Sqrt(x * x + y * y);
    }

    // Метод для переміщення точки на вектор (a, b).
    public void Move(double a, double b)
    {
        x += a;
        y += b;
    }

    public double this[int index]
    {
        get
        {
            if (index == 0) return x;
            if (index == 1) return y;
            throw new IndexOutOfRangeException("допустимі значення тільки '0' та '1' ");
        }
        set
        {
            if (index == 0) x = value;
            else if (index == 1) y = value;
            else throw new IndexOutOfRangeException("допустимі значення тільки '0' та '1'");
        }
    }
}

class Program
{
    static void Main()
    {
        point point1 = new point(3, 4);
        point point2 = new point();
        point1.Colour = "Green";

        point2.X = 3;
        point2.Y = 4;


        Console.WriteLine($"Кооридинати point2 X: {point2[0]} Y:{point2[1]} ");

        point2.scalar = 3;

        Console.WriteLine($"Кооридинати point2 помножених на скаляр 3 X: {point2[0]} Y:{point2[1]} ");

        // Виведення координат точок
        point1.showCoord();
        point2.showCoord();

        // Відстань до початку координат
        Console.WriteLine($"Дистанція точки 1 від початку координат: {point1.DistanceFromBegining()}");
        Console.WriteLine($"Дистанція точки 2 від початку координат: {point2.DistanceFromBegining()}");

        // Переміщення точки point1
        point1.Move(1, -2);
        Console.WriteLine("Координати точки 1 після переміщення:");
        point1.showCoord();
        point1.showColour();
    }
}