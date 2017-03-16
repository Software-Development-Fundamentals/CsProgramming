using System;

class Program
{
	static void Main(string[] args)
	{
		if(!IsOk(args))
		{
			Console.WriteLine("Parametrler duzgun daxil edilmeyib!");
			return;
		}


		string[] arguments = GetArguments(args);

		double num1 = StrToDouble(arguments[0]);
		double num2 = StrToDouble(arguments[2]);
		char operation = StrToChar(arguments[1]);

		double result = Calculate(num1, num2, operation);

		Console.WriteLine("Netice: " + result);
	}

	static bool IsOk(string[] args)
	{
		bool isOk = true;

		if(args == null || args.Length == 0 || args.Length < 2) 
			isOk = false;

		return isOk;
	}

	static string[] GetArguments(string[] args)
	{
		string[] arguments = null;

		if(args.Length == 2)
		{
			arguments = new string[3];
			arguments[0] = args[0];
			arguments[1] = args[1];
			arguments[2] = "0";
		}
		else
		{
			arguments = args;
		}

		return arguments;
	}


	static double Calculate(double num1, double num2, char operation)
	{
		double result = 0;

		switch (operation)
		{
			case '+': result = Add(num1, num2); break;
			case '-': result = Subtract(num1, num2); break;
			case '*': result = Multiply(num1, num2); break;
			case '/': result = Divide(num1, num2); break;
			case '!': result = CalcFactorial(num1); break;
		}

		return result;
	}

	static double Add(double num1, double num2)
	{
		return num1 + num2;
	}

	static double Subtract(double num1, double num2)
	{
		return num1 - num2;
	}

	static double Multiply(double num1, double num2)
	{
		return num1 * num2;
	}

	static double Divide(double num1, double num2)
	{
		if(num2 == 0)
		{
			Console.WriteLine("0-a bolmek olmaz");
			return 0;	
		}
		else
		{
			return num1 / num2;
		}
	}

	static double CalcFactorial(double num)
	{
		if (num == 0) return 1;

		return num * CalcFactorial(--num);
	}



	static char StrToChar(string str)
	{
		char ch = '\0'; //default value of char

		try 
		{
			ch = Convert.ToChar(str);
		}
		catch { Console.WriteLine("Emeliyyat duzgun daxil edilmeyib!"); }

		return ch;
	}

	static double StrToDouble(string str)
	{
		double d = 0;

		try
		{
			d = Convert.ToDouble(str);
		}
		catch { Console.WriteLine("Eded duzgun daxil edilmeyib!"); }

		return d;
	}
}
