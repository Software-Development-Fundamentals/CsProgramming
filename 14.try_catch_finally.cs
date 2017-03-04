/*
	Ədədin kvadratını hesablayan proqram
	Məqsəd: Try-Catch-Finally -nin mənimsənməsi.
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
		finally
		{
			Console.WriteLine("Netice: " + result);
		}
	}
}
