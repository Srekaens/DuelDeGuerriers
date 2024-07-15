using DuelsDeGuerriers.Classes;
using System.Threading;

Guerrier Flavinou = new Guerrier("Flavinou", 100);
Guerrier Justin = new Guerrier("Jujux", 100);
Guerrier Florentin = new Nain("FloFlo", 100, 10);
Guerrier Valentin = new Elfe("Valouh", 100);

int turns = 1;
    
#region "Première boucle"

while (Florentin.PointDeVie > 0 && Valentin.PointDeVie > 0)
{
    Console.WriteLine($"---------------------");
    Console.WriteLine($"Début du tour {turns}");
    Console.WriteLine($"---------------------");

    if (turns % 2 == 0)
    {
        Florentin.Attaquer(Valentin);
        Thread.Sleep(200);
    } else 
    {
        Valentin.Attaquer(Florentin);
        Thread.Sleep(200);
    }

    turns++;
}

if(Florentin.PointDeVie == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\t-------------------------");
    Console.WriteLine($"\tLe gagnant est {Valentin.Name}");
    Console.WriteLine($"\t-------------------------");
    Console.ForegroundColor = ConsoleColor.White;
} else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\t------------------------");
    Console.WriteLine($"\tLe gagnant est {Florentin.Name}");
    Console.WriteLine($"\t------------------------");
    Console.ForegroundColor = ConsoleColor.White;

}
#endregion