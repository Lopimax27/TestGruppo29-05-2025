
public abstract class Libro
{
    // Campi
    protected string titolo;
    protected int annoUscita;
    protected string autore;

    // Costruttore
    public Libro(string titolo, string autore, int annoUscita)
    {
        this.titolo = titolo;
        this.annoUscita = annoUscita;
        this.autore = autore;
    }

    // Metodo astratto - da implementare nelle sottoclassi
    public abstract string descrizioneLibro();

}
public class LibroFantasy : Libro
{
    string genre = "fantasy";
    public LibroFantasy(string titolo, string autore, int annoUscita, string genre) : base (titolo,autore,annoUscita)
    {
        this.genre = "Fantasy";
    }

    public override string descrizioneLibro()
    {
        return $"Libro {genre} ";
    }

}

public class LibroAvventura : Libro
{
    string genre ;
    public LibroAvventura(string titolo, string autore, int annoUscita, string genre) : base(titolo, autore, annoUscita)
    {
        this.genre = "Avventura";
    }

    public override string descrizioneLibro()
    {
        return $"Libro {genre} ";
    }

}
public class LibroHorror : Libro
{
    string genre = "horror";
    public LibroHorror(string titolo, string autore, int annoUscita, string genre) : base (titolo,autore,annoUscita)
    {
        this.genre = "horror";
    }

    public override string descrizioneLibro()
    {
        return $"Libro {genre} ";
    }

}
public static class CreazioneLibri
{
    public static Libro Libri(string tipo, string titolo , int annoUscita, string autore)
    {
        switch (tipo.ToLower())
        {
            case "fantasy": return new LibroFantasy(tipo, autore,annoUscita);
            case "avventura": return new LibroAvventura(tipo, autore,annoUscita);
            case "horror": return new LibroHorror(tipo, autore,annoUscita);
            default: throw new ArgumentException("Tipo Libro non valido");
        }
    }
}
