using System;

class zadanie6
{

    public static void Main()
    {
        Console.Write("podaj dlugosc tablicy ");
        int n = int.Parse(Console.ReadLine());
        int[] d = new int[n];
        for (int b = 0; b < d.Length; b++)
        {

            Console.Write("podaj " + b + " liczbe tablicy ");
            int x = int.Parse(Console.ReadLine());
            d[b] = x;

        }

        int j = 1;

    start:

        if (j < d.Length)
        {

            int i = 1;

        iii:

            if (i < d.Length)
            {

                if (d[i - 1] > d[i])
                {

                    int y;
                    y = d[i - 1];
                    d[i - 1] = d[i];
                    d[i] = y;
                    goto ddd;

                }

                else
                {

                    goto ddd;

                }

            ddd:

                i++;
                goto iii;

            }

            else
            {

                j++;
                goto start;

            }

        }

        else
        {

            for (int c = 0; c < d.Length; c++)
            {

                Console.WriteLine(d[c]);

            }

        }

    }

}