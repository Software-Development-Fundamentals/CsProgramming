/*
	İstənilən sözü tərsdən yazan proqram
	Məqsəd: foreach və array-lərin mənimsənməsi. ToCharArray() və Array.Reverse() metodlarının istifadəsi.
*/


using System;

class Program
{
	static void Main()
	{
		string soz = "Ceyhun";  //string tipli @soz dəyişəni təyin et və ona "Ceyhun" qiymətini mənimsət.
		string soz_ters = null; //string tipli @soz_ters dəyişəni təyin et və ona null qiymətini mənimsət.

		char[] herfler = soz.ToCharArray(); //string tipli @soz dəyişənini char[] tipinə çevir və char[] tipli @herfler dəyişəninə mənimsət.
		Array.Reverse(herfler); //@herfler array-inin elementlərini tərsinə sırala.

		
		foreach (var herf in herfler)
		{
			soz_ters += herf; //@herf dəyişəninin qiymətini @soz_ters dəyişəninin qiymətinə birləşdir.
		}


		Console.WriteLine(soz_ters); //@soz_ters dəyişənini konsola yaz.
	}
}
