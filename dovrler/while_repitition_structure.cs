/*
    Məqsəd: if şərt strukturundan yola çıxaraq
    while dövr strukturunu başa düşmək
*/

using System;

class Program
{
    static void Main()
    {
        int eded1 = 55; //int tipli @eded1 adlı dəyişən təyin edib ona 55 qiymətini mənimsədirik.
        int eded2 = 22; //int tipli @eded2 adlı dəyişən təyin edib ona 22 qiymətini mənimsədirik.

        bool sert = eded1 > eded2; //bool tipli @sert(şərt) adlı dəyişən təyin edib ona eded1 > eded2 şərtindən alınan qiyməti mənimsədirik.


        /*
            Əgər @sert(şərt) dəyişəni true olarsa,
            if strukturunun fiqurlu mötərizələri içərisinə yazılan
            əmrlər cəmi bircə dəfə icra olunacaq.

            Bu nümunədə @sert true olarsa, konsola cəmi bircə dəfə
            "IF strukturu: eded1 eded2-den boyukdur." yazılacaq.
        */
        if(sert)
        {
            Console.WriteLine("IF strukturu: eded1 eded2-den boyukdur.");
        }



        Console.WriteLine("Davam etmek ucun ENTER klik edin.");
        Console.ReadLine(); //if-dən while-a keçərkən konsolda fasilə yaratmaq üçün. ENTER klik etdikdə while-a keçid olunacaq.



        /*
            Əgər @sert(şərt) dəyişəni true olarsa,
            while strukturunun fiqurlu mötərizələri içərisinə yazılan
            əmrlər @sert true olduğu müddətdə icra olunacaq.

            Bu nümunədə @sert true olarsa, konsola sonsuz sayda
            "WHILE strukturu: eded1 eded2-den boyukdur." yazılacaq.
            Çünki while dövr strukturudur. @sert doğru olduqca
            fiqurlu mötərizələr içərisinə yazılan əmrlər dövr edərək icra olunacaq.
        */
        while(sert)
        {
            Console.WriteLine("WHILE strukturu: eded1 eded2-den boyukdur.");
        }
    }
}
