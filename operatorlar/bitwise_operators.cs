/*
    Məqsəd: Bitvari operatorları (&, |, ^, <<, >>) mənimsəmək.
*/

using System;

class Program
{
    static void Main()
    {
        int a = 60;         // 60 = 0011 1100
        int b = 13;         // 13 = 0000 1101 
        int c = 0;          //  0 = 0000 0000  


        //VƏ operatoru. (&)
        //DOĞRULUQ CƏDVƏLİ:
        /*
            0 & 0 = 0
            0 & 1 = 0
            1 & 0 = 0
            1 & 1 = 1
        */
        //HƏLLİ:
        /*
             0011 1100 (60)
            &
             0000 1101 (13)
            =
             0000 1100 (12)
        */
        c = a & b;
        Console.WriteLine("{0} & {1} = {2}", a, b, c);


        //VƏ YA operatoru. (|)
        //DOĞRULUQ CƏDVƏLİ:
        /*
            0 | 0 = 0
            0 | 1 = 1
            1 | 0 = 1
            1 | 1 = 1
        */
        //HƏLLİ:
        /*
             0011 1100 (60)
            |
             0000 1101 (13)
            =
             0011 1101 (61)
        */
        c = a | b;
        Console.WriteLine("{0} | {1} = {2}", a, b, c);


        //XOR operatoru. (^)
        //DOĞRULUQ CƏDVƏLİ:
        /*
            0 ^ 0 = 0
            0 ^ 1 = 1
            1 ^ 0 = 1
            1 ^ 1 = 0
        */
        //HƏLLİ:
        /*
             0011 1100 (60)
            ^
             0000 1101 (13)
            =
             0011 0001 (49)
        */
        c = a ^ b;
        Console.WriteLine("{0} ^ {1} = {2}", a, b, c);


        //SOLA SÜRÜŞDÜRMƏ operatoru. (<<)
        //HƏLLi:
        /*
            Bitləri 2 vahid sola sürüşdürmək üçün: 
            (0011 1100) << 2 = 1111 0000 (240)
        */
        c = a << 2;
        Console.WriteLine("{0} << 2 = {1}", a, c);


        //SAĞA SÜRÜŞDÜRMƏ operatoru. (>>)
        //HƏLLi:
        /*
            Bitləri 2 vahid sağa sürüşdürmək üçün: 
            (0011 1100) >> 2 = 0000 1111 (15)
        */
        c = a >> 2;
        Console.WriteLine("{0} >> 2 = {1}", a, c);
    }
}