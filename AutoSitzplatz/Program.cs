using System;

namespace AutoSitzplatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Auto bmw = new Auto(5);
            for (int i = 0; i < 8; i++)
            {
                bmw.einsteigen(2);
            }
        }
    }
}
