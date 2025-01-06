namespace Praxis_Abstrakte.Klassen.und.Methoden;

//Erbt von Arbeiter
class Informatiker : Arbeiter
{
    
    //Konstruktor Methode abrufen
    public Informatiker(string name, decimal gehalt) : base(name, gehalt)
    {
    }
    
    //Virtuelle Methode überschreiben, kann überschrieben werden oder (siehe Klasse Mechaniker)
    public override void ArbeitVerrichten()
    {
        Console.WriteLine($"Der Informatiker {Name} kommt ins Büro");
        Console.WriteLine($"Programmiert an Programme");
    }
}