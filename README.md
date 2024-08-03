# Duels de Guerriers

Ce programme simule des combats entre guerriers avec trois classes différentes : Guerrier, Nain et Elfe. Chaque classe a ses propres caractéristiques et capacités.

## Fonctionnalités

- **Guerrier** : Classe de base avec un nom, des points de vie et des valeurs de dégâts aléatoires.
- **Nain** : Hérite de Guerrier et possède un bonus de bouclier ajoutant des points de vie supplémentaires.
- **Elfe** : Hérite de Guerrier avec une plage de dégâts plus élevée.

## Utilisation

1. Clonez le dépôt ou téléchargez les fichiers source.

2. Ouvrez le projet dans votre IDE C# préféré (comme Visual Studio).

3. Compilez et exécutez le programme.

4. Le programme démarre un duel entre deux guerriers, Florentin (un Nain) et Valentin (un Elfe).

## Code Source Principal

```csharp
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
    } 
    else 
    {
        Valentin.Attaquer(Florentin);
        Thread.Sleep(200);
    }

    turns++;
}

if (Florentin.PointDeVie == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\t-------------------------");
    Console.WriteLine($"\tLe gagnant est {Valentin.Name}");
    Console.WriteLine($"\t-------------------------");
    Console.ForegroundColor = ConsoleColor.White;
} 
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\t------------------------");
    Console.WriteLine($"\tLe gagnant est {Florentin.Name}");
    Console.WriteLine($"\t------------------------");
    Console.ForegroundColor = ConsoleColor.White;
}

#endregion
```
## Classes

### **Guerrier** 

Classe de base représentant un guerrier avec un nom, des points de vie, et des valeurs de dégâts aléatoires.
```
namespace DuelsDeGuerriers.Classes
{
    internal class Guerrier
    {
        private string _name;
        private int _pointdevie;
        private int _valueDamage;

        Random aleatoire = new Random();
        public string Name { get => _name; set => _name = value; }
        public int PointDeVie { get => _pointdevie; set => _pointdevie = value < 0 ? 0 : value; }
        public virtual int ValueDamage { get => _valueDamage; set => _valueDamage = aleatoire.Next(1, 7); }

        public Guerrier(string name, int pointdevie)
        {
            Name = name;
            PointDeVie = pointdevie;
            ValueDamage = 0;
        }

        public void SubirDegats(int degats)
        {
            this.PointDeVie -= degats;
        }

        public void Attaquer(Guerrier cible)
        {
            cible.SubirDegats(this.ValueDamage);
            AfficherInfos(cible);
        }

        public void AfficherInfos(Guerrier cible)
        {
            Console.WriteLine($"{this.Name} attaque {cible.Name} ! Il est maintenant a {cible.PointDeVie} PDV.");
        }
    }
}
```

### **Nain**

Hérite de Guerrier et possède un bonus de bouclier ajoutant des points de vie supplémentaires.

```
namespace DuelsDeGuerriers.Classes
{
    internal class Nain : Guerrier
    {
        private int _ptBouclier;

        public int PtBouclier { get => _ptBouclier; set => _ptBouclier = value; }

        public Nain(string name, int pointdevie, int ptBouclier) : base(name, pointdevie)
        {
            PtBouclier = ptBouclier;
            PointDeVie += PtBouclier;
        }
    }
}
```

### **Elfe**

Hérite de Guerrier et possède une plage de dégâts plus élevée.

```
namespace DuelsDeGuerriers.Classes
{
    internal class Elfe : Guerrier
    {
        private int _valueDamage;

        Random aleatoire = new Random();

        public override int ValueDamage { get => _valueDamage; set => _valueDamage = aleatoire.Next(3, 7); }

        public Elfe(string name, int pointdevie) : base(name, pointdevie)
        {
            ValueDamage = _valueDamage;
        }
    }
}
