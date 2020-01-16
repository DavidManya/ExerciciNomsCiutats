using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            string ciutat1;
            string ciutat2;
            string ciutat3;
            string ciutat4;
            string ciutat5;
            string ciutat6;

            Console.WriteLine("Introduïu el nom de sis ciutats (premeu Enter cada cop)");
            ciutat1 = Console.ReadLine();
            ciutat2 = Console.ReadLine();
            ciutat3 = Console.ReadLine();
            ciutat4 = Console.ReadLine();
            ciutat5 = Console.ReadLine();
            ciutat6 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Has introduït aquestes ciutats:");
            Console.WriteLine(ciutat1);
            Console.WriteLine(ciutat2);
            Console.WriteLine(ciutat3);
            Console.WriteLine(ciutat4);
            Console.WriteLine(ciutat5);
            Console.WriteLine(ciutat6);

            //Fase 2
            Console.WriteLine();
            Console.WriteLine("Fase 2");
            Console.WriteLine("Mostrem el què hi ha dins l'array i ordenem alfabèticament:");
            string[] ArrayCiutats = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };
            Array.Sort(ArrayCiutats);

            for (int cont=0; cont < ArrayCiutats.Length; cont++)
            {
                Console.WriteLine(ArrayCiutats[cont]);
            }

            //Fase 3
            Console.WriteLine();
            Console.WriteLine("Fase 3");
            Console.WriteLine("En una nova Array canviarem les lletres 'a' per '4' i les ordenarem alfabèticament: ");
            string[] ArrayCiutatsModificades = { ciutat1.Replace('a', '4'), ciutat2.Replace('a', '4'), ciutat3.Replace('a', '4'), ciutat4.Replace('a', '4'), ciutat5.Replace('a', '4'), ciutat6.Replace('a', '4') };
            Array.Sort(ArrayCiutatsModificades);

            for (int cont = 0; cont < ArrayCiutatsModificades.Length; cont++)
            {
                Console.WriteLine(ArrayCiutatsModificades[cont]);
            }
        }
    }
}
