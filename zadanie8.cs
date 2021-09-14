using System;

class lista1
{
    public string[] lista = new string[1000];

    public string FIRST()
    {

        return lista[0];

    }

    public void ADD(string dodaj)
    {

        for(int i = 0; i < lista.Length; i++)
        {

            if(lista[i] == null)
            {

                lista[i] = dodaj;
                break;

            }

        }

    }
    public void REMOVE()
    {

        for (int i = 0; i < lista.Length; i++)
        {

            if (lista[i] == null)
            {

                lista[i - 1] = null;
                break;

            }

        }

    }

    public void PRINT()
    {

        for(int i = 0; i < lista.Length; i++)
        {

            if (lista[i] != null)
            {

                Console.WriteLine(lista[i]);

            }

        }

    }


}

class lista2
{
    public string[] lista = new string[1000];

    public string FIRST()
    {

        return lista[0];

    }
    
    public string LAST(string last)
    {

        for(int i = 0; i < lista.Length; i++)
        {

            if(lista[i] == null)
            {

                last = lista[i - 1];
                break;

            }

        }
        return last;
    }

    public void ADD(string dodaj)
    {

        for (int i = 0; i < lista.Length; i++)
        {

            if (lista[i] == null)
            {

                lista[i] = dodaj;
                break;

            }

        }

    }
    public void REMOVE(int usun)
    {
        if (lista[usun] != null)
        {

            lista[usun] = null;

        }
        else
        {

            Console.WriteLine("to miejsce jest puste");

        }
    }

    public void PRINT()
    {

        for (int i = 0; i < lista.Length; i++)
        {

            if(lista[i] != null)
            {

                Console.WriteLine(lista[i]);

            }

        }

    }


}

class test
{

    public static void Main()
    {

        lista1 l1 = new lista1();
        for(int i = 0; i < 3; i++)
        {

            Console.Write("podaj wyraz ");
            l1.ADD(Console.ReadLine());

        }

        Console.WriteLine("print1 ");
        l1.PRINT();

        for (int i = 0; i < 2; i++)
        {

            l1.REMOVE();

        }

        Console.WriteLine("print2 ");
        l1.PRINT();

        lista2 l2 = new lista2();
        for (int i = 0; i < 3; i++)
        {

            Console.Write("podaj wyraz ");
            l2.ADD(Console.ReadLine());

        }

        Console.WriteLine("print3 ");
        l2.PRINT();

        for (int i = 0; i < 2; i++)
        {

            Console.Write("podaj index wartosci do usuniecia ");
            l2.REMOVE(int.Parse(Console.ReadLine()));

        }

        Console.WriteLine("print4 ");
        l2.PRINT();

    }

}