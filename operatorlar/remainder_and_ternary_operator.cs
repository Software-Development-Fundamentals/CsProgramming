/*
	İstifadəçinin daxil etdiyi ədədin cüt və ya tək olduğunu tapan proqram.
*/

using System;

class Program
{
	static void Main()
	{
		double number = 0;
		string input = null;
		string output = null;

		Console.Write("Ededi daxil et: ");
		input = Console.ReadLine();
		number = Convert.ToDouble(input);

		output = (number % 2 == 0) ? "eded cutdur" : "eded tekdir";
		Console.WriteLine(output);
	}
}