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


        //3) %. bölmədən alınan qalığı(kəsr hissəni) qaytarır.
        /*
            Məsələn, z = 7 % 5 yazdıqda z = 2 olur, çünki, nəticədə bizə qalıq (kəsr hissə) qayıdır.
            7 % 5 => bir tam beşdən iki => qalıqda (kəsr hissədə) 2 alınır. 
            % operatoruda alınan qalığı yəni 2-ni qaytarır. 
        */
        a  = 5;
        b = 7;
        z = b % a; // z = b % a = 7 % 5 = 2


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
