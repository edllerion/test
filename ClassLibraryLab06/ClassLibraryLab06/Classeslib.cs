using System;
using System.Collections.Generic;
using System.Text;


class Bycycle
{
    public string brandname;
    public string countryProd;
    public int NumOfWheel;
    public string color;
    public int sizze;
    public int price;
    public double getSellPrice()
    {
        return price * 0.5;
    }
}
static void main(string[] args)
{
    Bycycle[] bycycles;
    Console.WriteLine("введіть кількість велосипедів");
    int cntBycycle = int.Parse(Console.ReadLine());
    bycycles = new Bycycle[cntBycycle];

    for (int i = 0; i < cntBycycle; i++)
    {


        Console.WriteLine("введіть назву бренду ");

        string sbrandname = Console.ReadLine();

        Console.WriteLine("введіть країну походженя ");

        string scountryProd = Console.ReadLine();

        Console.Write("введіть кількість коліс ");

        int sNumOfWheel = int.Parse(Console.ReadLine());

        Console.Write("введіть колір");

        string scolor = Console.ReadLine();

        Console.Write("введіть розмір ");

        int ssize = int.Parse(Console.ReadLine());

        Console.Write("введіть ціну ");

        int sprize = int.Parse(Console.ReadLine());

        Bycycle ABycecle = new Bycycle();

        ABycecle.brandname = sbrandname;
        ABycecle.countryProd = scountryProd;
        ABycecle.NumOfWheel = sNumOfWheel;
        ABycecle.color = scolor;
        ABycecle.sizze = ssize;
        ABycecle.price = sprize;
        double AgetSellPrice = ABycecle.getSellPrice();
        bycycles[i] = ABycecle;
    }
    foreach (Bycycle t in bycycles)
    {


        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("Дані про обьект:");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("назва бренду: " + t.brandname);
        Console.WriteLine("країна походження:" + t.countryProd);
        Console.WriteLine("кількість коліс: " + t.NumOfWheel);
        Console.WriteLine("колір: " + t.color);
        Console.WriteLine("розмір:" + t.sizze);
        Console.WriteLine("ціна:" + t.price);
        Console.WriteLine("ціна зі знижкою:" + t.getSellPrice());
        Console.ReadKey();
    }
}



