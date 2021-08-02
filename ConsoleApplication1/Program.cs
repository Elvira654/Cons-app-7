using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Za tri učitana broja ispitati da li je jedan od njih jednak sumi druga dva broja.
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double prvi, drugi, treci;
            Console.WriteLine("Unesite prvi broj: ");
            prvi = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            drugi = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treci broj: ");
            treci = double.Parse(Console.ReadLine());
            if (prvi == (drugi + treci))
            Console.WriteLine("Prvi broj jednak je zbiru drugog i treceg.");
            if (drugi == (prvi + treci))
            Console.WriteLine("Drugi broj jednak je zbiru prvog i treceg.");
            if (treci == (prvi + drugi))
            Console.WriteLine("Prvi broj jednak je zbiru prvog i drugog.");
            Console.ReadKey();
        }
    }
}
