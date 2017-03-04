/*
	İstənilən sözü tərsdən yazan proqram
	Məqsəd: for və array-lərin mənimsənməsi
*/


using System;

class Program
{
	static void Main()
	{
		string soz = "Ceyhun";  //string tipli @soz dəyişəni təyin et və ona "Ceyhun" qiymətini mənimsət.


		/*
		Qeyd:
			dəyişənə null qiyməti mənimsətdikdə o yaddaşda yer tutmur.

			Məsələn, əgər
			string soz = ""; yazsaq yaddaşda @soz dəyişəni üçün müəyyən yer ayrılır. Lakin,
			string soz = null; yazsaq yaddaşda @soz dəyişəni üçün yer ayrılmır.


		Qeyd 2:
			null qiymətini string və array tiplərində (keçdiyimiz tiplərdən) olan dəyişənlərə mənimsətmək olar.
			int, double, bool, char kimi tiplərdən olan dəyişənlərə mənimsətmək olmaz.
		*/
		string soz_ters = null; //string tipli @soz_ters dəyişəni təyin et və ona null qiymətini mənimsət.



		/*
		Qeyd:
			string tipində olan dəyişən əslində char tipli array-dir. Yəni,
			string soz1 = "Ceyhun"; yazılışı ilə char[] soz2 = { 'C', 'e', 'y', 'h', 'u', 'n' };
			yazılışı eynidir. Bu o deməkdir ki, mən iki halda da @soz1 və @soz2 dəyişənlərinin elementinə 
			indeksə görə müraciət edə bilərəm. Yəni,
			Console.WriteLine(soz1[0]);
			Console.WriteLine(soz2[0]); yazsam konsola 'C' hərfi çap olunacaq.


			Yuxarıdakı qeydə əsasən deyə bilərik ki, @soz bir array-dir. Proqramın məntiqini 
			array üzərində qura bilərik. Yəni, sözün tərsini tapmaq elə array-in tərsini tapmaq deməkdir.
			Array-ın tərsini tapmaq üçün onun sonuncu indeksindən ilk indeksinə kimi oxumaq lazımdır.
			Bir array-in son indeksi onun uzunluğundan bir vahid kiçik olur. Yəni, "Ceyhun" yazılışında uzunluq 6,
			sonuncu indeks isə 5dir:
			herf | index
			------------
			C	 |	 0
			e	 |	 1
			y	 |	 2
			h	 |	 3
			u	 |	 4
			n	 |	 5

			Deməli, istənilən array-in sonuncu indeksi onun uzunluğundan bir vahid kiçikdir. 
			İstənilən array-in ilk indeksi isə həmişə 0 olur.
			Array-ın tərsini tapmaq üçün həm sonuncu indeksi bilirik, həm də ilk indeksi.
		*/
		for ( int i = soz.Length - 1; i >= 0; i-- )
		{
			soz_ters += soz[i]; //@soz[i] qiymətini @soz_ters dəyişəninin qiymətinə birləşdir.
		}


		Console.WriteLine(soz_ters); //@soz_ters dəyişəninin qiymətini konsola yaz.
	}
}
