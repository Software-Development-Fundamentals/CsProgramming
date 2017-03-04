/*
    Virus :)

    Məqsəd: while dövr strukturunun mənimsənməsidir. 
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Proqrama xos gelmisiniz."); //konsola "Proqrama xos gelmisiniz." sətrini yaz.


        bool davamEt = true; //bool tipli @davamEt dəyişəni təyin et və ona true qiyməti mənimsət.


        /*
        Qeyd:
            while dövr strukturudur. 
            Yumru mötərizələr içərisinə yazılan şərt doğru olduğu müddətdə,
            fiqurlu mötərizə içərisinə yazılan əmrlər icra olunacaq.

            Yəni,
            əgər @davamEt dəyişəni true olarsa, fiqurlu mötərizə içərisində yazılan
            əmrlər icra olunacaq. Əksinə, @davamEt dəyişəni false olarsa, fiqurlu mötərizə
            içərisində yazılan əmrlər icra olunmayacaq.   
        */

        while( davamEt )
        {
            Console.Write("Proqramdan cixis etmek istiyirsen? [he/yox]: "); //konsola "Proqramdan cixis etmek istiyirsen? [he/yox]: " sətrini yaz.


            string input = Console.ReadLine(); // konsoldan istifadəçinin cavabını oxu və string tipli @input dəyişəninə mənimsət


            if(input == "he") //əgər istifadəçinin cavabı "he" olarsa,
                davamEt = false; // @davamEt dəyişəninə false qiyməti mənimsət.
        }
    }
}
