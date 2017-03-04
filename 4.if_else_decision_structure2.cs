/*
    Üç ədəd arasından ən böyük olanı tapan proqram.
    
    Məqsəd: If-else şərt strukturunun mənimsənməyidir.
*/

using System;

class Program
{
    static void Main()
    {
        /******************************************* Birinci ədədlə bağlı olan hissə *******************************************/
        Console.Write("Birinci ededi daxil edin: ");

        string input = Console.ReadLine();

        int eded1 = Convert.ToInt32(input);



        /******************************************* İkinci ədədlə bağlı olan hissə *******************************************/
        Console.Write("Ikinci ededi daxil edin: ");

        input = Console.ReadLine();

        int eded2 = Convert.ToInt32(input); 



        /******************************************* Üçüncü ədədlə bağlı olan hissə *******************************************/
        Console.Write("Ucuncu ededi daxil edin: ");

        input = Console.ReadLine();

        int eded3 = Convert.ToInt32(input); 



        /******************************************* Üç ədəddən ən böyük olanını tapan hissə ***********************************/

        if(eded1 > eded2) //əgər birinci ədəd ikinci ədəddən böyükdürsə,
        {
            if(eded1 > eded3) //və birinci ədəd üçüncü ədəddən böyükdürsə, deməli birinci ədəd böyükdür.
            {
                Console.WriteLine("En boyuk eded: " + eded1);
            }
            else //və birinci ədəd üçüncü ədəddən böyük deyilsə, deməli üçüncü ədəd böyükdür.
            {
                Console.WriteLine("En boyuk eded: " + eded3);
            }
        }
        else //birinci ədəd ikinci ədəddən böyük deyilsə,
        {
            if(eded2 > eded3) //və ikinci ədəd üçüncü ədəddən böyükdürsə, deməli ikinci ədəd böyükdür.
            {
                Console.WriteLine("En boyuk eded: " + eded2);
            }
            else //və ikinci ədəd üçüncü ədəddən böyük deyilsə, deməli üçüncü ədəd böyükdür.
            {
                Console.WriteLine("En boyuk eded: " + eded3);
            }
        }


    }
}
