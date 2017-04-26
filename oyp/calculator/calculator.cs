public class Calculator
{
    private double a;
    private double b;
    private char operation;

    public Calculator(double a, double b, char operation)
    {
        this.a = a;
        this.b = b;
        this.operation = operation;
    }

    public double Calculate()
    {
        double result = 0;

        switch (operation)
        {
            case '+': result = Add(a, b); break;
            case '-': result = Subtract(a, b); break;
            case '*': result = Multiply(a, b); break;
            case '/': result = Divide(a, b); break;
        }

        return result;
    }


    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
            return 0;
        return a + b;
    }
}