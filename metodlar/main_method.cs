/*
	Ədədi ortanı hesablayan proqram

	Məqsəd: Main metoda parametr ötürməyi və metodların istifadəsini mənimsəmək
*/

using System;

class Program
{
	static void Main(string[] args)
	{
		double[] nums = ToDoubleArray(args);
		double average = CalcAverage(nums);

		Console.WriteLine("Ededi orta: " + average);
	}

	static double[] ToDoubleArray(string[] args)
	{
		double[] nums = new double[args.Length];

		for(int i = 0; i < nums.Length; i++)
		{
			nums[i] = ToDouble(args[i]);
		}

		return nums;
	}

	static double ToDouble(string str)
	{
		double num = 0;

		try
		{
			num = Convert.ToDouble(str);
		}
		catch { }

		return num;
	}

	static double CalcAverage(double[] nums)
	{
		double sum = 0;
		double average = 0;
		double count = nums.Length;

		foreach(double num in nums)
			sum += num;

		average = sum / count;

		return average;
	}
}
