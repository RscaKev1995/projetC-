AfficherBienvenue();

string choix;
do
{
    Console.Write("Voulez-vous lancer la partie ? (1 pour oui, 2 pour non): ");
    choix = Console.ReadLine();

    if (choix != "1" && choix != "2")
    {
        Console.WriteLine("Veuillez entrer une valeur numérique de 1 ou 2 uniquement.");
    }
    else if (choix == "2")
    {
        Console.WriteLine("Vous avez choisi de ne pas lancer la partie.");
        Console.Write("Voulez-vous lancer la partie ? (1 pour oui, 2 pour non): ");
        choix = Console.ReadLine();
    }

} while (choix != "1" && choix != "2");

if (choix == "1")
{
    Console.WriteLine("Début de la partie !");
}
else if (choix == "2")
{
    AfficherBienvenue();
    Console.WriteLine("Vous avez choisi de ne pas lancer la partie.");
    
}
    

    static void AfficherBienvenue()
{
    Console.WriteLine("Bienvenue dans le jeu console C# Cars, jeu basé sur des lancers de dés qui va parcourir l'histoire de Cars 1 de Disney Pixar.");
}