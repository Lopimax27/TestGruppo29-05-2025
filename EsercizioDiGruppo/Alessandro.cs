
public interface ILibreria
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(Libri libro);
}

public sealed class GestoreLibreria : ILibreria
{
    private static GestoreLibreria _instance;

    private List<Libri> _listaLibri;
    private List<IObserver> _observers;

    private GestoreLibreria()
    {
        _listaLibri = new List<Libri>();
        _observers = new List<IObserver>();
    }

    public static GestoreLibreria GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GestoreLibreria();
        }
        return _instance;
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    // Rimuove un osservatore dalla lista
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    // Invia una notizia a tutti gli osservatori registrati
    public void Notify(Libri libri)
    {
        // Notifica tutti gli osservatori nella lista
        foreach (var observer in _observers)
        {
            _listaLibri.Add(libri);
            observer.Update(libri.Descrizione());
        }
    }

    public void StampaOrdini()
    {
        foreach (Libri o in _listaLibri)
        {
            Console.WriteLine(o);
        }
    }
}

