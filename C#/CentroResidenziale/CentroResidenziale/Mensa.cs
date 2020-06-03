using CentroResidenziale.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Linq;

namespace CentroResidenziale
{
    public class Mensa
    {
        private static class PrezziMensa
        {
            public const double MINIMO = 0.0;
            public const double PRIMA = 1.5;
            public const double SECONDA = 3.0;
            public const double MASSIMA = 5.0;
        }


        private List<Tesserino> TesseriniUtilizzati;
        public string Nome { get; set; }

        public Mensa(string nome)
        {
            this.Nome = nome;
            TesseriniUtilizzati = new List<Tesserino>();
        }

        public void ErogaPasto(Tesserino tesserino)
        {
            double costoPasto = PrezziMensa.MASSIMA;
            Tesserino tesserinoUtilizzato = TesseriniUtilizzati.FirstOrDefault(tesserinoCorrente => tesserinoCorrente.Numero == tesserino.Numero);
            if (tesserinoUtilizzato != null )
            {
                Console.WriteLine($"Il Tesserino: {tesserino.Numero} è stato già utilizzato");
                costoPasto = PrezziMensa.MASSIMA;
            } else
            {
                TesseriniUtilizzati.Add(tesserino);
                costoPasto = CalcolaCostPasto(tesserino);
            }

            Console.WriteLine($"Il Tesserino: {tesserino.Numero} paga {costoPasto} presso Mensa: {Nome}");
        }

        private double CalcolaCostPasto(Tesserino tesserino)
        {
            switch(tesserino.FasciaReddito)
            {
                case 0:
                    return PrezziMensa.MINIMO;
                case 1:
                    return PrezziMensa.PRIMA;
                case 2: 
                    return PrezziMensa.SECONDA;
                default:
                    return PrezziMensa.MASSIMA;
            }
        }

        public void StampaTesseriniUtilizzati()
        {
            Console.WriteLine("Tesserini utilizzati oggi:");
            this.TesseriniUtilizzati.ForEach(item =>
            {
                Console.WriteLine(item.Numero);
            });
        }

        public double PrezzoMedioDeiPastiErogati()
        {
            if (this.TesseriniUtilizzati.Count == 0)
                return 0.0;

            double totale = 0.0;
            this.TesseriniUtilizzati.ForEach(item => totale += CalcolaCostPasto(item));
            return totale / this.TesseriniUtilizzati.Count;
            
        }
    }
}
