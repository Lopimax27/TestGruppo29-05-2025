using System;

public class Program
{
    public static void Main()
    { 
        GestoreLibreria gestore = GestoreLibreria.GetInstance();
        bool continua = true;

        Console.WriteLine("=== SISTEMA GESTIONE LIBRERIA ===");
        
        while (continua)
        {
            Console.WriteLine("\n--- MENU PRINCIPALE ---");
            Console.WriteLine("1. Aggiungi libro");
            Console.WriteLine("2. Rimuovi libro");
            Console.WriteLine("3. Cerca libro");
            Console.WriteLine("4. Aggiorna libro");
            Console.WriteLine("5. Esci");
            Console.Write("Scegli un'opzione (1-5): ");
            
            string scelta = Console.ReadLine();
            
            switch (scelta)
            {
                case "1":
                    AggiungiLibro(gestore);
                    break;
                case "2":
                    RimuoviLibro(gestore);
                    break;
                case "3":
                    CercaLibro(gestore);
                    break;
                case "4":
                    AggiornaLibro(gestore);
                    break;
                case "5":
                    continua = false;
                    Console.WriteLine("Arrivederci!");
                    break;
                default:
                    Console.WriteLine("Opzione non valida. Riprova.");
                    break;
            }
        }
    }    private static void AggiungiLibro(GestoreLibreria gestore)
    {
        Console.WriteLine("\n--- AGGIUNGI LIBRO ---");
        Console.Write("Inserisci il titolo: ");
        string titolo = Console.ReadLine() ;
        
        Console.Write("Inserisci l'autore: ");
        string autore = Console.ReadLine() ;
        
        Console.Write("Inserisci l'anno di uscita: ");
        if (int.TryParse(Console.ReadLine(), out int anno))
        {
            Console.WriteLine("Scegli il tipo di libro:");
            Console.WriteLine("1. Fantasy");
            Console.WriteLine("2. Avventura");
            Console.WriteLine("3. Horror");            Console.Write("Tipo (1-3): ");
            
            string tipoScelta = Console.ReadLine();
            string tipo = "";
            
            switch (tipoScelta)
            {
                case "1":
                    tipo = "fantasy";
                    break;
                case "2":
                    tipo = "avventura";
                    break;
                case "3":
                    tipo = "horror";
                    break;
                default:
                    Console.WriteLine("Tipo non valido.");
                    return;
            }
            
            try
            {
                Libro libro = CreazioneLibri.Libri(tipo);
                // Nota: qui dovremmo impostare i dati del libro
                Console.WriteLine($"Libro '{titolo}' di {autore} ({anno}) aggiunto con successo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore nell'aggiunta del libro: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Anno non valido.");
        }
    }    private static void RimuoviLibro(GestoreLibreria gestore)
    {
        Console.WriteLine("\n--- RIMUOVI LIBRO ---");
        Console.Write("Inserisci il titolo del libro da rimuovere: ");
        string titolo = Console.ReadLine();
        
        // Implementazione della rimozione
        Console.WriteLine($"Funzionalità di rimozione per il libro '{titolo}' non ancora implementata.");
    }

    private static void CercaLibro(GestoreLibreria gestore)
    {
        Console.WriteLine("\n--- CERCA LIBRO ---");
        Console.WriteLine("Cerca per:");
        Console.WriteLine("1. Titolo");
        Console.WriteLine("2. Autore");
        Console.WriteLine("3. Anno");        Console.Write("Scegli criterio di ricerca (1-3): ");
        
        string criterio = Console.ReadLine();
        
        switch (criterio)
        {
            case "1":
                Console.Write("Inserisci il titolo: ");
                string titolo = Console.ReadLine();
                Console.WriteLine($"Ricerca per titolo '{titolo}' non ancora implementata.");
                break;
            case "2":
                Console.Write("Inserisci l'autore: ");
                string autore = Console.ReadLine();
                Console.WriteLine($"Ricerca per autore '{autore}' non ancora implementata.");
                break;
            case "3":
                Console.Write("Inserisci l'anno: ");
                string anno = Console.ReadLine();
                Console.WriteLine($"Ricerca per anno '{anno}' non ancora implementata.");
                break;
            default:
                Console.WriteLine("Criterio non valido.");
                break;
        }
    }    private static void AggiornaLibro(GestoreLibreria gestore)
    {
        Console.WriteLine("\n--- AGGIORNA LIBRO ---");
        Console.Write("Inserisci il titolo del libro da aggiornare: ");
        string titolo = Console.ReadLine();
        
        Console.WriteLine("Cosa vuoi aggiornare?");
        Console.WriteLine("1. Titolo");
        Console.WriteLine("2. Autore");
        Console.WriteLine("3. Anno");
        Console.Write("Scegli cosa aggiornare (1-3): ");
        
        string scelta = Console.ReadLine();
        
        switch (scelta)
        {
            case "1":
                Console.Write("Inserisci il nuovo titolo: ");
                string nuovoTitolo = Console.ReadLine();
                Console.WriteLine($"Aggiornamento titolo da '{titolo}' a '{nuovoTitolo}' non ancora implementato.");
                break;
            case "2":
                Console.Write("Inserisci il nuovo autore: ");
                string nuovoAutore = Console.ReadLine();
                Console.WriteLine($"Aggiornamento autore per '{titolo}' a '{nuovoAutore}' non ancora implementato.");
                break;
            case "3":
                Console.Write("Inserisci il nuovo anno: ");
                string nuovoAnno = Console.ReadLine();
                Console.WriteLine($"Aggiornamento anno per '{titolo}' a '{nuovoAnno}' non ancora implementato.");
                break;
            default:
                Console.WriteLine("Opzione non valida.");
                break;
        }
    }
}