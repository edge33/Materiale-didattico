using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CentroResidenziale.Models
{
    public class Tesserino
    {
        public Tesserino(int numero)
        {
            Numero = numero;
        }

        public int Numero { get; set; }
        public int FasciaReddito { get; set; }
        public override string ToString()
        {
            return $"Tesserino: {Numero} - Fascia di reddito {FasciaReddito}";
        }

    }
}
