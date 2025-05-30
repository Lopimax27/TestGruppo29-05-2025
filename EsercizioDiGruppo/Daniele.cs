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
