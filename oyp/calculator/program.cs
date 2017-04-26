using System;

class Program
{
    static void Main()
    {
        double num1 = 15;
        double num2 = 30;
        double result = 0;
        char operation = '*';

        Calculator calculator = new Calculator(num1, num2, operation);
        result = calculator.Calculate();
        ShowResult(result);

        result = Calculator.Add(5, 9);
        ShowResult(result);
    }

    static void ShowResult(double result)
    {
        string output = string.Format("Result is {0}", result);
        Console.WriteLine(output);
    }
}
