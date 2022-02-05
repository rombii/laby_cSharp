namespace lab9;

public class Ocena
{
    public string przedmiot { get; set; }
    public int ocena { get; set; }

    public Ocena(string przedmiot, int ocena)
    {
        this.przedmiot = przedmiot;
        this.ocena = ocena;
    }
    public Ocena() {}
}