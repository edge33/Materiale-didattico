using CentroResidenziale.Models;
using System;

namespace CentroResidenziale
{
    class Program
    {
        static void Main(string[] args)
        {
            CentroResidenziale centroResidenziale = new CentroResidenziale();
            Mensa mensaIngegneria = new Mensa("Mensa Ingegneria");
            
            Persona persona = new Studente("Domenico", "Cavallaro");
            persona.CodiceFiscale = "MMCVLR";
            persona.RedditoFamiliare = 20000;
            Persona persona2 = new Studente("Angelo", "Rossi");
            persona2.RedditoFamiliare = 7850;

            
            
            Studente studente = centroResidenziale.ImmatricolaStudente(persona);
            Studente studente2 = centroResidenziale.ImmatricolaStudente(persona2);

            mensaIngegneria.ErogaPasto(studente.Tesserino);
            mensaIngegneria.ErogaPasto(studente2.Tesserino);

            mensaIngegneria.StampaTesseriniUtilizzati();
            double prezzoMedio = mensaIngegneria.PrezzoMedioDeiPastiErogati();
            Console.WriteLine($"Prezzo medio pasti erogati: {prezzoMedio}");
        }
    }
}
