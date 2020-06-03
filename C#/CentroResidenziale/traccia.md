## Centro Residenziale


Si realizzi una console application che modelli il dominio applicativo di un centro residenziale il cui ruolo è quello di immatricolare studenti e generare tesserini con fasce di reddito differenti per l'accesso al servizio mensa.

In particolare l'applicazione dovrà prevedere la possbilità di modellare le entità:

- **Studente**
- **Centro Residenziale**
- **Mensa**
  
Tenendo presente che: 

- Il Centro Residenziale dovrà tenere conto del reddito familiare dello studente per generare il tesserino.
- La Mensa erogherà pasti il cui costo è relativo alla fascia di reddito del tesserino.
- Per ogni tesserino è possibile erogare un solo pasto per fascia di prezzo, in caso di utilizzo multiplo del tesserino verrò applicato il coso massimo.

I dettagli dell'implementazione per le entità sono lasciati volutamente generici per garantire massima libertà di progettazione.


Si vuole però tenere traccia dei tesserini generati e dei pasti erogati, al fine di poter eseguire le seguenti operazioni:

- Stampare tutti i tesserini che hanno usufruito del servizio mensa
- Calcolare il prezzo medio dei pasti erogati (senza tenere conto di eventuali utilizzi multipli di un tesserio)