/*
    Operatorlar. İkili (Binary) operatorlara aid nümunələr.
*/

class Program
{
    static void Main()
    {
        int a = 5, b = 6, z = 7;
        bool flag = false;


        //İkili operatorlar: +, -,  %, >, <, ==, != və s.
        //İkili operatorlara aid nümunələr:
        //1) +
        z = b + a;

        //2) -
        z = b - a;


        //3) %. bölmədən alınan qalığı qaytarır.
        /*
            Məsələn, z = 6 % 5 yazdıqda z = 2 olur, çünki,
            6 / 5 = 1.2 yəni burada 1 tam hissə, 2 isə qalıb hissədir.
            % operatoruda bölmədədn alınan qalığı yəni 2-ni qaytarır. 
        */
        z = b % a; // z = b % a = 6 % 5 = 2


        //4) >
        flag = b > a; // flag = b > a = 6 > 5 = true;

        //5) <
        flag = b < a; // flag = b < a = 6 < 5 = false;

        //6) ==. bərabərliyi yoxlayır. bərabərdirlərsə true, bərabər deyillərsə false qaytarır.
        flag = b == a; // flag = b == a = 6 == 5 = false;

        //7) !=. bərabərliyi yoxlayır. bərabər deyillərsə true, bərabərdirlərsə false qaytarır.
        flag = b != a; // flag = b != a = 6 != 5 = true;
    }
}
