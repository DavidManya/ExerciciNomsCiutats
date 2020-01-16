using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
