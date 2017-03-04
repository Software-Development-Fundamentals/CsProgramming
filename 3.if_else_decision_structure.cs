/*
    İki ədəd arasından ən böyük olanı tapan proqram.
    
    Məqsəd: if-else şərt strukturunun mənimsənməyi
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci ededi daxil edin: "); //konsola "Birinci ededi daxil edin: " sətrini yaz.


        /*
            konsoldan istifadəçinin daxil etdiyi birinci ədədi oxu və
            string tipli @input dəyişəninə mənimsət.
        */
        string input = Console.ReadLine();



        /*
        Qeyd:
            Konsoldan oxuduğumuz məlumat sətir olduğuna görə tipi string-dir.
            Bilirik ki, string tipli dəyişənlər üzərində riyazi hesablamalar apara bilmərik.
            Bunun üçün string tipli dəyişəni ədəd tipli dəyişənə çevirmək lazımdır, məsələn int tipinə.
            string tipli dəyişəni int tipinə çevirmək üçün Convert.ToInt32() metodundan istifadə etməliyik.
        */


        int eded1 = Convert.ToInt32(input); // @input dəyişənini int tipinə çevir və int tipli @eded1 dəyişəninə mənimsət.





        Console.Write("Ikinci ededi daxil edin: "); //konsola "Ikinci ededi daxil edin: " sətrini yaz.



        /*
            konsoldan istifadəçinin daxil etdiyi birinci ədədi oxu və
            string tipli @input dəyişəninə mənimsət.

        Qeyd:
            @input dəyişənini yuxarıda təyin etmişik deyə
            bir daha təyin etməyə ehtiyyac yoxdur. Ona görə qarşısında "string" yazılmayıb.
            Əgər aşağıda @input dəyişəninin qarşısında string yazılsaydı bu səhv olacaqdı, çünki
            eyni adlı dəyişəni yalnız bir dəfə təyin etmək olar.
        */
        input = Console.ReadLine();


        int eded2 = Convert.ToInt32(input); // @input dəyişənini int tipinə çevir və int tipli @eded2 dəyişəninə mənimsət.


        /*
        Qeyd:
            Artıq birinci və ikinci ədədi aldığımıza görə
            hansının böyük olduğu təyin edə bilərik.
        */


        if(eded1 > eded2) //əgər birinci ədəd ikinci ədəddən böyükdürsə,
        {
            Console.WriteLine("Birinci eded ikinci ededden boyukdur"); //konsola "Birinci eded ikinci ededden boyukdur" yaz.
        }
        else //birinci ədəd ikinci ədəddən böyükdür deyilsə,
        {
            Console.WriteLine("Ikinci eded birinci ededden boyukdur"); //konsola "Ikinci eded birinci ededden boyukdur" yaz.
        }

        
    }
}
