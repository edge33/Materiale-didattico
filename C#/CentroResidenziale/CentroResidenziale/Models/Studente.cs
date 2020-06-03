namespace CentroResidenziale.Models
{
    public class Studente: Persona
    {
        public int Matricola { get; set; }
        public Tesserino Tesserino { get; set; }
        public Studente(string nome, string cognome, string codiceFiscale = "") : base(nome, cognome, codiceFiscale)
        {
        }

        public Studente(Persona persona): base(persona.Nome, persona.Cognome, persona.CodiceFiscale)
        {  
        }

        public override string ToString()
        {
            return $"Studente: {base.ToString()} - {Matricola} - {Tesserino}";
        }
    }
}
