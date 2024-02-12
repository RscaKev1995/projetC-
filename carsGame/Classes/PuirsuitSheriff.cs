using System;
using static carsGame.Classes.CastingVehicles;
namespace carsGame.Classes
{
    public class PuirsuitSheriff
    {
        public static void ExecutePursuit()
        {
            
            
            Console.Clear();
            do
            {
                Console.WriteLine("Appuyez sur Enter pour lancer les dés ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Des des = new Des();
                    int sheriffScore = des.LancerDes() * CastingVehicles.Sheriff.DrivingSkills * (int)(CastingVehicles.Sheriff.PercentageOfLuck * 100);
                    int mcQueenScore = des.LancerDes() * McQueen.DrivingSkills * (int)(McQueen.PercentageOfLuck * 100);

                    if (sheriffScore > mcQueenScore)
                    {
                        Console.WriteLine($"Avec un score de : {sheriffScore}, le Sheriff rattrape Flash ! Voulez-vous recommencer ? (1 pour Oui, 2 pour Non)");
                        string response = Console.ReadLine();

                        while (response != "1" && response != "2")
                        {
                            Console.WriteLine("Veuillez entrer 1 pour Oui ou 2 pour Non.");
                            response = Console.ReadLine();
                        }

                        if (response == "2")
                        {
                            Console.WriteLine("Fin de la partie.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Avec un score de : {mcQueenScore}, McQueen arrive à passer entre les mailles du sheriff et va quitter la ville quand soudain...");
                        StartGame.AttendreTroisSeconde();
                        Console.WriteLine($"Le réservoir de Flash semble vide, il n'a plus moyen de rouler et le {Sheriff.NameOfTheVehicle} finit par le rattraper et le mettre en prison");
                        StartGame.AttendreTroisSeconde();

                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez appuyer uniquement sur Enter.");
                }

            } while (true);
        }
    }
}
