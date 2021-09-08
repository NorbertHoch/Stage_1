using System;

class zadanie4
{

    public static void Main()
    {

        Console.Write("podaj liczbe liczb ");
        int y = int.Parse(Console.ReadLine());

        int z;

        double[] x = new double[y];
        for (int i0 = 0; i0 < x.Length; i0++)
        {

            Console.Write("podaj {0} liczbe ", (i0 + 1));
            z = int.Parse(Console.ReadLine());

            x[i0] = z;

        }

        foreach (int i2 in x)
        {

            Console.WriteLine("foreach " + i2);

        }

        for (int i1 = 0; i1 < x.Length; i1++)
        {

            Console.WriteLine("for " + x[i1]);

        }

        int i3 = 0;

        while (i3 < x.Length)
        {

            Console.WriteLine("while " + x[i3]);
            i3++;

        }

        int i4 = 0;

        do
        {

            Console.WriteLine("do while " + x[i4]);
            i4++;

        } while (i4 < x.Length);

    }

}