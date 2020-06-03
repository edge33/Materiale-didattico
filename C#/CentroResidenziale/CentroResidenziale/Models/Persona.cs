using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CentroResidenziale.Models
{
    public class Persona
    {
        public Persona(string nome, string cognome, string codiceFiscale = "")
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public double RedditoFamiliare { get; set; }

        public override string ToString()
        {
            return $"Persona: {Nome} - {Cognome} - {CodiceFiscale} - {RedditoFamiliare}";
        }
    }
}
