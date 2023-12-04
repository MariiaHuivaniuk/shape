using System;

abstract class Shape
{
    public string name;
    public string Name { get; set; }

    public Shape(string name)
    {
        this.name = name;
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    public double radius;

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Square : Shape
{
    public double side;

    public Square(string name, double side) : base(name)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return 4 * side;
    }
}

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle("Circle 1", 5);
        Circle circle2 = new Circle("Circle 2", 7);

        Square square1 = new Square("Square 1", 4);
        Square square2 = new Square("Square 2", 6);

        Console.WriteLine($"{circle1.Name}: Area = {circle1.Area()}, Perimeter = {circle1.Perimeter()}");
        Console.WriteLine($"{circle2.Name}: Area = {circle2.Area()}, Perimeter = {circle2.Perimeter()}");

        Console.WriteLine($"{square1.Name}: Area = {square1.Area()}, Perimeter = {square1.Perimeter()}");
        Console.WriteLine($"{square2.Name}: Area = {square2.Area()}, Perimeter = {square2.Perimeter()}");

        // Finding and displaying the area of the largest square and circle
        double largestSquareArea = Math.Max(square1.Area(), square2.Area());
        double largestCircleArea = Math.Max(circle1.Area(), circle2.Area());

        Console.WriteLine($"Largest Square Area: {largestSquareArea}");
        Console.WriteLine($"Largest Circle Area: {largestCircleArea}");
    }
}