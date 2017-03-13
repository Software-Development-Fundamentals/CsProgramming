/*
    Virus :)

    Məqsəd: do-while dövr strukturunun mənimsənməsidir. 
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Proqrama xos gelmisiniz."); //konsola "Proqrama xos gelmisiniz." sətrini yaz.


        bool davamEt = false; //bool tipli @davamEt dəyişəni təyin et və ona false qiyməti mənimsət.


        /*
        Qeyd:
            do-while dövr strukturudur.
            İlk olaraq "do"-dan sonra gələn fiqurlu mötərizə içərisinə yazılan əmrlər icra olunacaq.
            Daha sonra "while"-ın yumru mötərizələri içərisinə yazılan şərt doğru olduğu müddətdə,
            "do"-dan sonra gələn fiqurlu mötərizə içərisinə yazılan əmrlər yenidən icra olunmağa davam edəcək.


            Yəni,
            İlk olaraq @davamEt dəyişəni istər true olsun, istər false fiqurlu mötərizə içərisində yazılan
            əmrlər icra olunacaq. Daha sonra isə əgər @davamEt dəyişəni true olarsa, fiqurlu mötərizə
            içərisində yazılan əmrlər yenidən icra olunacaq, əgər @davamEt dəyişəni false olarsa icra olunmayacaq.   
        */
        do
        {
            Console.Write("Proqramdan cixis etmek istiyirsen? [he/yox]: "); //konsola "Proqramdan cixis etmek istiyirsen? [he/yox]: " sətrini yaz.


            string input = Console.ReadLine(); // konsoldan istifadəçinin cavabını oxu və string tipli @input dəyişəninə mənimsət


            if(input == "he") //əgər istifadəçinin cavabı "he" olarsa,
            {
                davamEt = false; //@davamEt dəyişəninə false qiyməti mənimsət.
            }
            else //əgər istifadəçinin cavabı "he" deyilsə,
            {
                davamEt = true; //@davamEt dəyişəninə true qiyməti mənimsət.
            }
        }
        while( davamEt ); //@davamEt dəyişəni true olarsa, "do"-dan sonra gələn fiqurlu mötərizələr içərisində yazılan əmrlər yenidən icra olunacaq.
    }
}
