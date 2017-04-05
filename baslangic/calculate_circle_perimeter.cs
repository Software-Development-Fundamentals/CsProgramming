/*
	 İstifadəçinin daxil etdiyinin radiusa uyğun çevrənin perimetrini hesablayan proqram.
*/

using System;

class Program
{
	static void Main()
	{
		double radius = 0;
		double perimeter = 0;
		string input = null;
		const double pi = 3.14;	//PI ədədinin qiyməti sabitdir. 
					//C#-da qiyməti sabit dəyişənləri göstərmək üçün 
					//dəyişənin qarşısında const yazırıq.


		Console.Write("Cevrenin radiusunu daxil et: ");
		input = Console.ReadLine();
		radius = Convert.ToDouble(input);
		perimeter = 2 * pi * radius; 

		Console.WriteLine("Cevrenin radiusu: " + perimeter);
	}
}
