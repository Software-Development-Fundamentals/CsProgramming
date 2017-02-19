/*
    İstifadəçini salamlayan proqram.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Adinizi daxil edin: "); //konsola "Adinizi daxil edin:" sətrini yaz.


        string istifadecinin_adi = Console.ReadLine(); //konsoldan istifadəçinin adını oxu və @istifadecinin_adi dəyişəninə mənimsət.


        Console.WriteLine("Salam, " + istifadecinin_adi); //istifadəçinin adını konsola yaz.
    }
}
