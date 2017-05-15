using System;

class Program
{
    static void Main()
    {        
        Figure[] figures = 
        { 
            new Circle(4), //s = 48, p = 24
            new Square(6), //s = 36, p = 24 
            new Triangle(7, 8) //s = 28, p = 21
        };


        foreach(Figure figure in figures)
        {
            Console.WriteLine("{0} sahesi {1} ve perimetri {2}.",
                figure, figure.GetArea(), figure.GetPerimeter());
        }
    }
}