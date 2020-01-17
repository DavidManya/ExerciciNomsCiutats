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

            //Fase 4
            Console.WriteLine();
            Console.WriteLine("Fase 4");

            string[] Barcelona;
            Barcelona = new string ["Barcelona".Length];

            string[] Madrid;
            Madrid = new string["Madrid".Length];

            string[] Valencia;
            Valencia = new string["Valencia".Length];

            string[] Malaga;
            Malaga = new string["Malaga".Length];

            string[] Cadis;
            Cadis = new string["Cadis".Length];

            string[] Santander;
            Santander = new string["Santander".Length];

            //Introduir nom de ciutats lletra per lletra
            Console.WriteLine("Escriu 'Barcelona' lletra per lletra (prem Enter)");
            for (int i = 0; i < Barcelona.Length; i++)
            {
                Barcelona[i] = Console.ReadLine();
            }
            Console.WriteLine("Escriu 'Madrid' lletra per lletra (prem Enter)");
            for (int i = 0; i < Madrid.Length; i++)
            {
                Madrid[i] = Console.ReadLine();
            }
            Console.WriteLine("Escriu 'València' lletra per lletra (prem Enter)");
            for (int i = 0; i < Valencia.Length; i++)
            {
                Valencia[i] = Console.ReadLine();
            }
            Console.WriteLine("Escriu 'Málaga' lletra per lletra (prem Enter)");
            for (int i = 0; i < Malaga.Length; i++)
            {
                Malaga[i] = Console.ReadLine();
            }
            Console.WriteLine("Escriu 'Cadis' lletra per lletra (prem Enter)");
            for (int i = 0; i < Cadis.Length; i++)
            {
                Cadis[i] = Console.ReadLine();
            }
            Console.WriteLine("Escriu 'Santander' lletra per lletra (prem Enter)");
            for (int i = 0; i < Santander.Length; i++)
            {
                Santander[i] = Console.ReadLine();
            }

            //Ara mostrarem per consola el nom de la ciutat tant del dret com del revés
            //Barcelona
            string dret = "";
            string separador = "-";
            for (int i = 0; i < Barcelona.Length; i++)
            {
                string juntar = dret;
                dret = juntar + Barcelona[i];
            }
            string reves = dret + separador;
            for (int i = Barcelona.Length - 1; i >= 0; i--)
            {
                string juntar = reves;
                reves = juntar + Barcelona[i];
            }
            Console.WriteLine();
            Console.WriteLine(reves);

            //Madrid
            dret = "";

            for (int i = 0; i < Madrid.Length; i++)
            {
                string juntar = dret;
                dret = juntar + Madrid[i];
            }
            reves = dret + separador;
            for (int i = Madrid.Length - 1; i >= 0; i--)
            {
                string juntar = reves;
                reves = juntar + Madrid[i];
            }
            Console.WriteLine();
            Console.WriteLine(reves);

            //València
            dret = "";

            for (int i = 0; i < Valencia.Length; i++)
            {
                string juntar = dret;
                dret = juntar + Valencia[i];
            }
            reves = dret + separador;
            for (int i = Valencia.Length - 1; i >= 0; i--)
            {
                string juntar = reves;
                reves = juntar + Valencia[i];
            }
            Console.WriteLine();
            Console.WriteLine(reves);

            //Màlaga
            dret = "";

            for (int i = 0; i < Malaga.Length; i++)
            {
                string juntar = dret;
                dret = juntar + Malaga[i];
            }
            reves = dret + separador;
            for (int i = Malaga.Length - 1; i >= 0; i--)
            {
                string juntar = reves;
                reves = juntar + Malaga[i];
            }
            Console.WriteLine();
            Console.WriteLine(reves);

            //Cadis
            dret = "";

            for (int i = 0; i < Cadis.Length; i++)
            {
                string juntar = dret;
                dret = juntar + Cadis[i];
            }
            reves = dret + separador;
            for (int i = Cadis.Length - 1; i >= 0; i--)
            {
                string juntar = reves;
                reves = juntar + Cadis[i];
            }
            Console.WriteLine();
            Console.WriteLine(reves);

            //Santander
            dret = "";

            for (int i = 0; i < Santander.Length; i++)
            {
                string juntar = dret;
                dret = juntar + Santander[i];
            }
            reves = dret + separador;
            for (int i = Santander.Length - 1; i >= 0; i--)
            {
                string juntar = reves;
                reves = juntar + Santander[i];
            }
            Console.WriteLine();
            Console.WriteLine(reves);
        }
    }
}
