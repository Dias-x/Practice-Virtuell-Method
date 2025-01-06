namespace Praxis_Abstrakte.Klassen.und.Methoden;

//Erbt von Arbeiter
class Mechaniker : Arbeiter
{

    //Konstruktor Methode abrufen
    public Mechaniker(string name, decimal gehalt) : base(name, gehalt)
    {
    }
    
    /*Virtuelle Methode gelöscht, ergibt kein Fehler. Es ist nicht falsch, wenn man keine
    Virtuelle Methode löscht oder nichts implementiert*/
    
    
    //Abstrakte Methode wird als Virtuelle Methode erkannt
    
    public override void ArbeitVerrichten()
    {
        Console.WriteLine($"Der Mechaniker {Name} kommt in die Garage");
        Console.WriteLine($"Repariert Autos");
    }
}