/*
    İş axtaranın parametrlərinə (yaş və boy) görə
    mühafizə işinə qəbul proqramı
*/

using System;

class Program
{
    static void Main()
    {
        byte yas = 18; // istifadəçinin yaşı
        float boy = 1.70f; //istifadəçinin boyu


        /*
            Əgər iş axtaranın
            yaşı 18dən böyükdürsə və boyu 1.70dən çoxdursa,
            mühafizə işinə qəbul olunsun.
        */
        if(yas > 18 && boy > 1.70)
        {
            Console.WriteLine("Siz mühafizə işinə qəbul olundunuz");
        }
        else
        {
            Console.WriteLine("Siz mühafizə işinə qəbul olunmadınız");
        }
    }
}
