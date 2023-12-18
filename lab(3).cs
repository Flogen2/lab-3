using System;

//Клас Rectangle
class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        //Клас Rectangle
        Console.Write("Введіть довжину сторони 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");

        //Класи Point та Figure
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(1, 0, "B");
        Point pointC = new Point(1, 1, "C");
        Point pointD = new Point(0, 1, "D");

        Figure figure = new Figure(pointA, pointB, pointC, pointD);
        figure.CalculatePerimeter();
    }
}

//Класи Point та Figure
class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3, Point point4 = null, Point point5 = null)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X-A.X,2)+Math.Pow(B.Y-A.Y,2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

