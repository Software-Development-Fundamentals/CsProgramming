using System;

class Program
{
	static void Main()
	{
		double num1 = 0;
		double num2 = 0;
		double result = 0;
		char operation = '\0';
		string input = null;
		bool repeat = false;

		do 
		{
			input = WriteAndRead("Birinci ededi daxil et: ");
			num1 = StrToDouble(input);

			input = WriteAndRead("Ikinci ededi daxil et: ");
			num2 = StrToDouble(input);

			input = WriteAndRead("Emeliyyati daxil et: ");
			operation = StrToChar(input);

			result = Calculate(num1, num2, operation);
			Console.WriteLine("Netice: " + result);

			input = WriteAndRead("Proqramdan cixmaq isteyirsen? [he/yox]: ");
			Console.WriteLine();
			if(!Exit(input))
				repeat = true;
			else
				repeat = false;
		}
		while(repeat);
	}


	static string WriteAndRead(string output)
	{
		string input = null;

		Console.Write(output);

		input = Console.ReadLine();

		return input;
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

	static bool Exit(string input)
	{
		bool exit = false;

		if(input == "he") 
			exit = true;

		return exit;
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
