using System;

namespace RabatBeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key!");
            var rabat = new Rabatberegner();
            rabat.GetPrisEfterRabat(301, 102.102);
            Console.ReadKey();
        }
    }


    public class Rabatberegner
    {
        public double GetPrisEfterRabat(int antalVarer, double stykPris)
        { 
            var prisRabat = 0.03;
            var antalRabat = 0.02;
            var rabatFaktor = 0.0;
            double bruttoPris = antalVarer * stykPris;

            if (bruttoPris > 1000)
                rabatFaktor += prisRabat;

            if (antalVarer > 10)
                rabatFaktor += antalRabat;

            double rabat = bruttoPris * rabatFaktor;
            bruttoPris -=  rabat;
            return bruttoPris;
        }
    }
}
