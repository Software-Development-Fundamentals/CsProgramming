class Circle : Figure
{
    private const double PI = 3;
    public double Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * PI * Radius;
    }
}