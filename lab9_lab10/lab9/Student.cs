using System;
using System.Collections.Generic;

namespace lab9;

[Serializable]
public class Student
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public int nr { get; set; }
    public string wydzial { get; set; }

    [NonSerialized]public List<Ocena> listaOcen = new List<Ocena>();

    public Student(string imie, string nazwisko, int nr, string wydzial)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.nr = nr;
        this.wydzial = wydzial;
        
    }

    public Student()
        : this("", "", 0, "")
    {}
}