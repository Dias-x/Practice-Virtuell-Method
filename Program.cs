using System;
using Praxis_Abstrakte.Klassen.und.Methoden;
    

class Program
{
    static void Main(string[] args)
    {
        
        //Die Virtuelle Methode in der Klasse "Informatiker" wird ausgeführt
        Informatiker dias = new Informatiker("Dias", 6400);
        dias.ArbeitVerrichten();

        Console.WriteLine();
        
        //Die Virtuelle Methode in der Klasse "Arbeiter" wird ausgeführt
        Mechaniker jens = new Mechaniker("Jens", 5400);
        jens.ArbeitVerrichten();

        Console.WriteLine();
        
        //Es wird angezeigt, namespace und am schluss die Klasse welches abgerufen wurde
        Informatiker andre = new Informatiker("Andre", 6400);
        Console.WriteLine(andre.ToString());
    }
}