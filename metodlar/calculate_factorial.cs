/*
	Konsol yazılarının rəngini dəyişən proqram.

	Məqsəd: Məqsəd: Main metoda parametr ötürməyi və metodların istifadəsini mənimsəmək
*/

using System;

class Program
{
	static void Main(string[] args)
	{
		if(args.Length == 0) return;

		int number = int.Parse(args[0]);
		int factorial = CalcFactorial(number);
		Console.WriteLine("Faktorial: {0}", factorial);
	}

	static int CalcFactorial(int number)
	{		
		int result = 1;

		// number = 4 olduqda, result = result * i. Onda, 
		// result = 1 * 1 = 1
		// result = 1 * 2 = 2
		// result = 2 * 3 = 6
		// result = 6 * 4 = 24
		for (int i = 1; i <= number; i++)
		{
			result *= i;
		}

		return result;
	}
}