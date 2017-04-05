/*
	 İstidəçinin daxil etdiyi ədədin vurma cədvəlini konsola yazan proqram.
	 Məqsəd: for dövr strukturunun mənimsənməsi.
*/

using System;

class Program
{
	static void Main()
	{
		int number = 0;
		string input = null;

		Console.Write("Eded daxil et: ");
		input = Console.ReadLine();
		number = Convert.ToInt32(input);


		Console.WriteLine();
		Console.WriteLine(number + " ededinin vurma cedveli: ");
		for(int i = 0; i <= 10; i++)
		{
			Console.WriteLine(number + " * " + i + " = " + number * i);
		}
	}
}