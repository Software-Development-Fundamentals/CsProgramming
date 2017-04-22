using System;

class Program
{
    static void Main()
    {
        Insan fuad = new Insan("Fuad", "Sabalidi");
        Console.WriteLine(fuad.GozRengi);

    }
}

class Insan
{
    /* field */
    public string ad;
    private int boy;
    private string gozRengi;

    /* constructor */
    public Insan(string ad) /* */
    {
        this.ad = ad;
    }

    public Insan(string ad, string gozRengi)
    {
        this.ad = ad;
        this.gozRengi = gozRengi;
    }

    /* property */
    public int Boy 
    {
        get { return boy; }
        set 
        {
            if(value > 0) 
                boy = value;
            else
                Console.WriteLine("yas menfi ola bilmez");
        }
    }

    public string GozRengi 
    {
        get { return gozRengi; }
    }

    /* methods */
    public void Danismaq()
    {
        Console.WriteLine("Men danisiriam");
    }
}

