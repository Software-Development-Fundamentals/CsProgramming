/*
    Həftənin gününə görə iş yoxsa istirahət günü olduğunu
    təyin edən proqram.

    Məqsəd: switch/case şərt strukturunun mənimsənməsidir. 
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Heftenin gununu daxil edin: ");

        string input = Console.ReadLine();
        
        int gun = Convert.ToInt32(input);


        switch(gun)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Bu gun is gunudur");
                break;
    
            case 6:
            case 7:
                Console.WriteLine("Bu gun istirahet gunudur");
                break;

            default:
                Console.WriteLine("Zehmet olmasa hefte gunu daxil edin");
                break;
        }
    }
}
