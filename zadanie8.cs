using System;

class list1
{

    public string[] elementy = new string[3];

    public void Add(string dodaj)
    {

        if (elementy[0] == null)
        {

            elementy[0] = dodaj;

        }
        else
        {
            for (int i = 0; i < elementy.Length; i++)
            {

                if (elementy[i] == null)
                {

                    elementy[i] = dodaj;
                    break;

                }

            }
        }

    }
    public void Remove(int usun)
    {

        elementy[usun] = null;

    }

    public void Print()
    {

        for (int j = 0; j < elementy.Length; j++)
        Console.WriteLine(elementy[j]);

    }

    }

    class list2
    {

        public string[] elementy = new string[3];

        public void Add(string dodaj)
        {

            if (elementy[0] == null)
            {

                elementy[0] = dodaj;

            }
            else
            {
                for (int i = 0; i < elementy.Length; i++)
                {

                    if (elementy[i] == null)
                    {

                        elementy[i] = dodaj;
                        break;

                    }

                }
            }
        }
    

        public void Remove(int usun)
        {

            elementy[usun] = null;

        }

        public void Print()
        {

            for (int j = 0; j < elementy.Length; j++)
                Console.WriteLine(elementy[j]);

        }

        public string Prev(int liczba, string x)
        {

            x = "null";

            if (elementy[liczba - 1] == null)
            {

                return x;

            }
            else
            {

                return elementy[liczba - 1];

            }


        }

        public string Next(int liczba, string x)
        {

            x = "null";

            if (elementy[liczba + 1] == null)
            {

                return x;

            }
            else
            {

                return elementy[liczba + 1];

            }


        }

    }

    class zadanie8
    {

        public static void Main()
        {

            list2 lista = new list2();
        
        for (int i = 0; i < 3; i++)
            {

                Console.Write("podaj " + (i + 1) + " element tablicy ");
                lista.Add(Console.ReadLine());

            }

            lista.Print();

            for (int i = 0; i < 2; i++)
            {

                Console.Write("podaj index elementu tablicy do usuniecia ");
                lista.Remove(int.Parse(Console.ReadLine()));

            }

            lista.Print();

            list1 lista1 = new list1();

            for (int i = 0; i < 3; i++)
            {

                Console.Write("podaj " + (i + 1) + " element tablicy ");
                lista1.Add(Console.ReadLine());

            }

            lista1.Print();

            for (int i = 0; i < 2; i++)
            {

            Console.Write("podaj index elementu tablicy do usuniecia ");
            lista1.Remove(int.Parse(Console.ReadLine()));
            
            }

            lista1.Print();

        }

    }