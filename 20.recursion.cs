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


	static int CalcFactorial(int num)
	{
		if (num == 0) return 1;

		return num * CalcFactorial(--num);
	}
}
