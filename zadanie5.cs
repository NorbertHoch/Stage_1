using System;

class Licz
{

    private int wartosc;

    public Licz(int wart)
    {

        wartosc = wart;

    }

    public int dodaj(int plus)
    {

        wartosc += plus;
        return wartosc;

    }

    public int odejmij(int minus)
    {

        wartosc -= minus;
        return wartosc;

    }

    public void wypisz()
    {

        Console.WriteLine(wartosc);

    }

}

class zadanie5
{

    public static void Main()
    {

        Licz liczba1 = new Licz(10);

        Console.Write("podaj liczbe ");
        int x = int.Parse(Console.ReadLine());
        Licz liczba2 = new Licz(x);

        Console.Write("podaj liczbe do odjecia ");
        int y = int.Parse(Console.ReadLine());
        liczba2.odejmij(y);

        liczba1.dodaj(10);
        liczba1.odejmij(1);

        liczba1.wypisz();
        liczba2.wypisz();

    }

}