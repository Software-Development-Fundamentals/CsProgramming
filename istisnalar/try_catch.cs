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
		input = Console.ReadLine(); //istifadəçinin daxil etdiyini oxu və @input dəyişəninə mənimsət.


		/*
			Əgər istifadəçi ədəd əvəzinə simvol və ya söz daxil edərsə, biz onu ədədə çevirə bilmərik.
			Məsələn,
			
			//1ci hal
			string input = "5";
			int num = Convert.ToInt32(input); // @num dəyişəninin qiyməti 5 olacaq.
			
			
			//2ci hal
			input = "soz";
			num = Convert.ToInt32(input); //@num dəyişəninin qiyməti təyin olunmayacaq. Çünki "soz" -ü ədədə çevirmək mümkün deyil.
			
			
			Birinci halda hər şey qaydasındadır, çevirmə mümkün olacaq. Ancaq ikinci halda çevirmə mümkün olmuyacaq və bu hal istisna adlanır.
			Ona görə istisna adlanır ki, biz istifadəçidən ədəd daxil etməyini gözləyirik, o isə ədəd daxil etmir. Buna görə bu hal istisna adlanır.
			Bölmə zamanı 0-a bölməni də istisna kimi göstərmək olar.
			İkinci halda istisna baş verir. Biz istisnanı tutmaq üçün və yarana biləcək problemin qarşısını almaq üçün try/catch-dən istifadə etməliyik.
		*/
		
		
		/*
			try-ın fiqurlu mötərizələri içərisində istisna yarada biləcək kodlar yazılır.
			Məsələn, çevirmə zamanı istisna hal yaranır deyə biz try-ın fiqurlu mötərizələri
			arasında "num = Convert.ToInt32(input);" kodunu yazmışıq.
		*/
		try
		{
			num = Convert.ToInt32(input);
		}
		/*
			catch-in fiqurlu mötərizələri içərisində istisna baş verərsə, proqramın nə etməli olduğu yazılır.
			Məsələn, biz burda proqramın konsola "Zehmet olmasa eded daxil edin" yazısını çıxarmalı olduğunu
			göstərmişik.
		*/
		catch
		{
			Console.WriteLine("Zehmet olmasa eded daxil edin");
		}


		result = num * num; //ədədin kvadratını hesabla və @result dəyişəninə mənimsət
		Console.WriteLine("Netice: " + result);
	}
}
