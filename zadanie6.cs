using System;

class zadanie3
{

    public static void Main()
    {

        Random x = new Random(10);
        x.Next(10);

    start:

        Console.Write("podaj liczbe 0-9 ");
        int y = int.Parse(Console.ReadLine());
        if (y == x.Next(10))
        {

            Console.WriteLine("zgadles!");
            goto start;

        }
        else
        {

            Console.WriteLine("nie zgadles :c");
            goto start;

        }


    }

}