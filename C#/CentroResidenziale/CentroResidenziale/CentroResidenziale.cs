using CentroResidenziale.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace CentroResidenziale
{
    public class CentroResidenziale
    {
        private List<Studente> StudentiImmatricolati { get; set; }
        private int NumeroMatricolaCorrente;

        public CentroResidenziale()
        {
            this.NumeroMatricolaCorrente = 0;
            this.StudentiImmatricolati = new List<Studente>();
        }

        public Studente ImmatricolaStudente(Persona persona)
        {
            Studente studente = (Studente) persona;
            int numeroMatricola = NumeroMatricolaCorrente++;
            studente.Matricola = numeroMatricola;
            this.StudentiImmatricolati.Add(studente);
            Tesserino tesserino = new Tesserino(numeroMatricola);
            tesserino.FasciaReddito = CalcolaFasciaReddito(studente);
            studente.Tesserino = tesserino;
            return studente;
        }

        private int CalcolaFasciaReddito(Studente studente)
        {
            double reddito = studente.RedditoFamiliare;
            if (reddito <= 0)
            {
                return 0;
            }
            else if (reddito <= 10000)
            {
                return 1;
            }
            else if (reddito <= 20000)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}
