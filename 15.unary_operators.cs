/*
    Operatorlar. Təkli(Unary) operatorlara aid nümunələr.
*/

class Program
{
    static void Main()
    {
        int a = 5, b = 0;
        bool flag = false, condition = false;


        //təkli operatorlar: +, -, ++, --, !, ~
        //Təkli operatorlara aid nümunələr:
        //1) +
        b = +a; // b = +a = 5;


        //2) -
        b = -a; // b = -a = -5;

        //3) ++
        ++a; // pre-increment: əvvəl 1 vahid artırır sonra qiyməti qaytarır. a = ++5 = 6
        a++; // post-increment: əvvəl qiyməti qaytarır sonra 1 vahid artırır. a = 5++ = 5 => 6


        //4) --
        b = 6;
        --b; // pre-decrement: əvvəl 1 vahid azaldır sonra qiyməti qaytarır. //b = --6 = 5; 
        b--; // post-decrement: əvvəl qiyməti qaytarır sonra 1 vahid azaldır. //b = 6-- = 6 => 5;


        //5) ! - yalnız bool tipli ifadələrdə istifadə olunur və əks  nəticəni qaytarır.
        condition = !flag; // condition = !false = true;


        //6) ~ bitvari operatordur. ədədin bitlərini tərsinə çevirir.
        /*
            Məsələn,
            5 rəqəmi ikilik say sistemində              0000 0101 kimi yazılır.
            ~5 yazdıqda bitlər tərsinə çevrilir, nəticə 1111 1010 olur.
            Alınan nəticə ikilik say sistemində -6 dır.

        Qeyd:
            İmtahanda cavabı tapmağın qısa yolu belədir:
            '~'simvolundan sonra gələn rəqəmin (və ya ədədin) üzərinə 1 gəlib qarşısına -1 rəqəminə vurun.
            
            Məsələn, ~5 ifadəsində nəticə (5 + 1) * -1 olacaq yəni -6.
        */
        b = ~5; //b = ~5 = -6;
    }
}
