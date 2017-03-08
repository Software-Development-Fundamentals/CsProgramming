/*
	İki ədədin cəmini hesablayan proqram

	Məqsəd: Metodları mənimsəmək
*/

using System;

class Program
{
	static void Main()
	{
		double num1, num2, result;
		string input = null;

		input = WriteAndRead("Birinci ededi daxil et: ");
		num1 = StrToDouble(input, "Birinci ededi yanlis daxil etmisiniz!");

		input = WriteAndRead("Ikinci ededi daxil et: ");
		num2 = StrToDouble(input, "Ikinci ededi yanlis daxil etmisiniz!");

		result = Add(num1, num2);
		Console.Write("Netice: " + result);
	}


	static string WriteAndRead(string output)
	{
		string input = null;

		Console.Write(output);
		input = Console.ReadLine();

		return input;
	}


	static double StrToDouble(string str, string errorMsg)
	{
		double result = 0;

		try
		{
			result = Convert.ToDouble(str);
		}
		catch { Console.WriteLine(errorMsg); }

		return result;
	}

	static double Add(double num1, double num2)
	{
		return num1 + num2;
	}
}
