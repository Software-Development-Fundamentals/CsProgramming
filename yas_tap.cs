/*
    İstifadəçinin yaşını hesablayan proqram.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Doguldugunuz ili daxil edin: "); //konsola "Doguldugunuz ili daxil edin: " sətrini yazırıq

        string input = Console.ReadLine(); // konsoldan istifadəçinin təvəllüdünü oxu və string tipli @input dəyişəninə mənimsət


        /*
            Konsoldan oxuduğumuz məlumat sətir olduğuna görə tipi string-dir.
            Bilirik ki, string tipli dəyişənlər üzərində riyazi hesablamalar apara bilmərik.
            Bunun üçün string tipli dəyişəni ədəd tipli dəyişənə çevirmək lazımdır, məsələn int tipinə.
            string tipli dəyişəni int tipinə çevirmək üçün Convert.ToInt32() metodundan istifadə etməliyik.
        */


        int tevellud = Convert.ToInt32(input); // @input dəyişənini int tipinə çevir və int tipli @tevellud dəyişəninə mənimsət


        /*
            istifadəçinin yaşını tapmaq üçün 
            hazırki ildən (2017) istifadəçinin təvəllüdünü çıxırıq
            və bunu int tipli @yas dəyişəninə mənimsədirik.
        */
        int yas = 2017 - tevellud;


        Console.WriteLine("Sizin yaşınız: " + yas); // İstifadəçinin yaşını konsola yazırıq.
    }
}
