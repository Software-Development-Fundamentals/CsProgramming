/*
    Operatorlar. Üçlü (ternary) operatora aid nümunələr.
*/

using System;

class Program
{
    static void Main()
    {
        bool sert = true;

        //Üçlü operator: ? :
        //Üçlü operatora aid nümunələr:
        //sintaksis. şərt ? şərt_doğru_olduqda : şərt_yanlış_olduqda;

        string s = (sert ? "sert_dogrudur" : "sert_yanlisdir");
        Console.WriteLine(s);


        // və ya aşağıdakı kimi


        Console.WriteLine(sert ? "sert_dogrudur" : "sert_yanlisdir");
    }
}
