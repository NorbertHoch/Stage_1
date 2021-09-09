using System;

class zadanie7
{

    public static void Main()
    {
        Console.Write("podaj liczbe a ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("podaj liczbe b ");
        int b = int.Parse(Console.ReadLine());

        while(a != b)
        {

            if(a > b)
            {

                a -= b;

            }

            else if (a < b)
            {

                b -= a;

            }

        }

        Console.WriteLine("wartosc a wynosi: " + a);

    }

}