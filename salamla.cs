/*
    İstifadəçini salamlayan proqram.
*/

using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Adinizi daxil edin: "); //konsola "Adinizi daxil edin:" sətrini yaz.


        /*
            konsoldan istifadəçinin adını oxu və 
            string tipli @istifadecinin_adi dəyişəninə mənimsət.
        */
        string istifadecinin_adi = Console.ReadLine();


        Console.WriteLine("Salam, " + istifadecinin_adi); //istifadəçinin adını konsola yaz.
    }
}
