using System;
// INTERFACCIA IObserver
public interface IObserver
{
    void Update(string message);
}

// CLASSE UTENTE CHE IMPLEMENTA IObserver
public class Utente : IObserver
{
    public string Nome { get; private set; }

    public Utente(string nome)
    {
        Nome = nome;
    }

    public void Update(string message)
    {
        Console.WriteLine($"NOTIFICA per {Nome}: {message}");
    }
}

// GESTIONE OBSERVER
public interface ILibreria
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}

// IMPLEMENTAZIONE DELL'OBSERVER
public class Libreria : ILibreria
{
    private List<IObserver> utenti = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        utenti.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        utenti.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var utente in utenti)
        {
            utente.Update(message);
        }
    }
}

public abstract class Libro {
    // Campi
    protected string titolo;
    protected int annoUscita;
    protected string autore;

    // Costruttore
    public Libro(string titolo, string autore, int annoUscita) {
        this.titolo = titolo;
        this.annoUscita = annoUscita;
        this.autore = autore;
    }

    // Metodo astratto - da implementare nelle sottoclassi
    public abstract String descrizioneLibro();

}
public static class CreazioneLibri
{
    public static Libro Libri(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "fantasy": return new LibroFantasy();
            case "avventura": return new LibroAvventura();
            case "horror": return new LibroHorror();
            default: throw new ArgumentException("Tipo Libro non valido");
        }
    }
}

class Programs
{
    public static void Main()
    {

    }
}