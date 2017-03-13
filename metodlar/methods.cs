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


		//konsola "Birinci ededi daxil et: " yaz və istifadəçinin daxil etdiyini @input dəyişəninə mənimsət.
		input = WriteAndRead("Birinci ededi daxil et: "); 


		/*
			istifadəçinin daxil etdiyini ədədə çevir və @num1 dəyişəninə mənimsət.
			Əgər çevirmə mümkün olmazsa, konsola "Birinci ededi yanlis daxil etmisiniz!" yazılacaq və @num1 dəyişəninə 0 mənimsədiləcək.
		*/
		num1 = StrToDouble(input, "Birinci ededi yanlis daxil etmisiniz!");




		//konsola "Ikinci ededi daxil et: " yaz və istifadəçinin daxil etdiyini @input dəyişəninə mənimsət.
		input = WriteAndRead("Ikinci ededi daxil et: ");


		/*
			istifadəçinin daxil etdiyini ədədə çevir və @num2 dəyişəninə mənimsət.
			Əgər çevirmə mümkün olmazsa, konsola "Ikinci ededi yanlis daxil etmisiniz!" yazılacaq və @num2 dəyişəninə 0 mənimsədiləcək.
		*/
		num2 = StrToDouble(input, "Ikinci ededi yanlis daxil etmisiniz!");



		result = Add(num1, num2); //@num1 və @num2 ədədlərinin cəmini @result dəyişəninə mənimsət.
		Console.Write("Netice: " + result); //@result dəyişənini konsola yaz.
	}



	/*
		WriteAndRead metodu - konsola yazır və istifadəçinin daxil etdiyini qaytarır.

		parametrlər:
			@output - konsola yazılır.

		qaytarılır: istifadəçinin daxil etdiyi.
	*/
	static string WriteAndRead(string output)
	{
		string input = null; //string tipli @input dəyişəni yarat və ona null (default qiymətini) mənimsət. 

		Console.Write(output); //konsola @output dəyişəninin qiymətini yaz.
		input = Console.ReadLine(); //istifadəçinin daxil etdiyini oxu və @input dəyişəninə mənimsət.

		return input; //@input dəyişənini qaytar.
	}



	/*
		StrToDouble metodu - string tipli dəyişənin qiymətini double tipli dəyişənə çevirir.
		Əgər çevirmə mümkün olmazsa, konsola error mesajı yazır.

		parametrlər:
			@str - çevirmək istədiyimiz dəyişən.
			@errorMsg - çevirmə mümkün olmadıqda konsola yazılan mesaj.

		qaytarılır: çevrilən ədəd. (əgər çevirmə mümkün olmazsa, 0 qaytarılır)
	*/	
	static double StrToDouble(string str, string errorMsg)
	{
		double result = 0;

		try
		{
			result = Convert.ToDouble(str);
		}
		catch 
		{ 
			Console.WriteLine(errorMsg); 
		}

		return result;
	}


	/*
		Add metodu - iki ədədin cəmi hesablayır və nəticəni qaytarır.

		parametrlər:
			@num1 - birinci ədəd
			@num2 - ikinci ədəd 

		qaytarılır: birinci və ikinci ədədin cəmi
	*/
	static double Add(double num1, double num2)
	{
		return num1 + num2;
	}
}
