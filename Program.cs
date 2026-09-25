
using System;

namespace Pizzakalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MOMS = 0.12;

            Console.WriteLine("Hur många pizzor vill du köpa?");
            int antalPizzor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad kostar en pizza?");
            double prisPerPizza = Convert.ToDouble(Console.ReadLine());

            double totalsummaUtanMoms = antalPizzor * prisPerPizza;
            double momsbelopp = totalsummaUtanMoms * MOMS;
            double totalsummaMedMoms = totalsummaUtanMoms + momsbelopp;

            Console.WriteLine("Totalsumma utan moms: " + totalsummaUtanMoms + " kr");
            Console.WriteLine("Momsbelopp: " + momsbelopp + " kr");
            Console.WriteLine("Totalsumma med moms: " + totalsummaMedMoms + " kr");
        }
    }
}
