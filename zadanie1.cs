﻿using System;

class zadanie
{

    public static void Main()
    {

    start:

        Console.Write("podaj liczbe a ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("podaj liczbe b ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("podaj liczbe c ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {

            Console.WriteLine("podano złą wartość ");
            goto start;

        }
        else
        {

            double delta = b * b - 4 * a * c;
            switch (delta) {
            case > 0:

                delta = Math.Round(Math.Sqrt(delta));

                double x1 = (-b - delta) / (2 * a);
                double x2 = (-b + delta) / (2 * a);

                Console.WriteLine("x1: {0:#.##} x2: {1:#.##} ", x1, x2);
                break;

            case 0:

                double x0 = -b / (2 * a);
                Console.WriteLine("x0: {0:#.##} ", x0);
                break;

            default:

                Console.WriteLine("brak pierwiastkow");
                break;
            }

        }

    }

}