/*
	Ədədin faktorialını hesablayan proqram

	Məqsəd: Rekursiv metodları mənimsəmək
*/

using System;

class Program
{
	static void Main()
	{
		int number = 5;
		int result = CalcFactorial(number);
		Console.WriteLine("Netice: " + result);
	}

	// number = 5 olduqda, result = num * CalcFactorial(--num) olur. Onda, 

	// result = 5 * CalcFactorial(4) = 5 * 24 = 120
	// CalcFactorial(4) = 4 * CalcFactorial(3) = 4 * 6 = 24
	// CalcFactorial(3) = 3 * CalcFactorial(2) = 3 * 2 = 6
	// CalcFactorial(2) = 2 * CalcFactorial(1) = 2 * 1 = 2
	// CalcFactorial(1) = 1 * CalcFactorial(0) = 1 * 1 = 1
	static int CalcFactorial(int num)
	{
		if (num == 0) return 1;

		return num * CalcFactorial(--num);
	}
}
