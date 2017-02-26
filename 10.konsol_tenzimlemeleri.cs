/*
Rənglər:

Black
Blue	
Cyan	
DarkBlue	
DarkCyan	
DarkGray	
DarkGreen	
DarkMagenta	
DarkRed	
DarkYellow	
Gray	
Green	
Magenta	
Red	
White	
Yellow
*/

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Mənim proqramım"; //Konsolun başlığını dəyişmək üçün. Burada adətən proqramın adı yazılır.
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Konsolda azərbaycan hərflərini (ə, i, ü və s.) göstərmək üçün



        /*
            Konsolun axra plan rəngini dəyişmək üçün.

        Qeyd:
            Nümunədə konsolun axra plan rəngi ağ təyin edilmişdir.
            Dəyişmək üçün White əvəzinə yuxarıda qeyd edilən rənglərdən 
            hər-hansısa biri yazıla bilər.
        */
        Console.BackgroundColor = ConsoleColor.White;



        /*
            Konsoldakı yazıların rəngini dəyişmək üçün.

        Qeyd:
            Nümunədə konsoldakı yazıların rəngi qara təyin edilmişdir.
            Dəyişmək üçün Black əvəzinə yuxarıda qeyd edilən rənglərdən 
            hər-hansısa biri yazıla bilər.
        */
        Console.ForegroundColor = ConsoleColor.Black;


        Console.WriteLine("Salam, necəsən?");
        Console.ReadLine();
    }
}
