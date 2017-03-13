/*
	Ədədin kvadratını hesablayan proqram
	Məqsəd: Try-Catch -in mənimsənməsi.
*/


using System;

class Program
{
	static void Main()
	{
		int num = 0;
		int result = 0;
		string input = null;

		Console.Write("Birinci ededi daxil et: ");
		input = Console.ReadLine();

		try
		{
			num = Convert.ToInt32(input);
			result = num * num;
		}
		catch
		{
			Console.WriteLine("Zehmet olmasa eded daxil edin");
		}

		Console.WriteLine("Netice: " + result);
	}
}
