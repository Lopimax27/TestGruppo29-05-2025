using System;

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