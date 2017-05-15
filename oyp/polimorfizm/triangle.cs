class Triangle : Figure //Bərabərtərəfli üçbucaq
{
    public double Side { get; set; }
    public double Height { get; set; }

    public Triangle(double side, double height)
    {
        Side = side;
        Height = height;
    }

    public override double GetArea()
    {
        return Side * Height / 2;
    }

    public override double GetPerimeter()
    {
        return 3 * Side;
    }
}