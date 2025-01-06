namespace Praxis_Abstrakte.Klassen.und.Methoden;

//Abstrakte Klasse = Basis Klasse
abstract class Arbeiter
{

    //Eigenschaften
    public string Name { get; set; }
    public decimal Gehalt { get; set; }


    //Konstruktor Methode
    public Arbeiter(string name, decimal gehalt)
    {
        Name = name;
        Gehalt = gehalt;
    }


    //Methode
    public void PrintInformation()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gehalt: {Gehalt}");
    }

    //Virtuelle Methode, so sieht es aus. Es muss im Codeblock was implementiert sein
    public virtual void ArbeitVerrichten()
    {
        Console.WriteLine($"Arbeiter verrichtet seine Arbeit");
    }


    //"ToString" wird überschrieben und hat eine rückgabewert
    public override string ToString()
    {
        return $"Es handelt sich um einen Informatiker. Name: {Name}";
    }
}