using System;
using static carsGame.Classes.CastingVehicles;
namespace carsGame.Classes
{
    public class FirstRaceDoc
    {
        public static void RaceDoc()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Le lendemain matin, {CastingVehicles.McQueen.NameOfTheVehicle} et {CastingVehicles.DocHudson.NameOfTheVehicle} se retrouve sur la ligne de départ pour une course ou si Flash s'en sort gagnant, il pourra s'en aller pour la Piston Cup et tenter d'arriver premier là-bas. ");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Et c'est parti pour cette course ! ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Flash est bien parti pour gagner , le Doc n'a même pas encore démarré ! ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Et c'est le dernier virage, McQueen va battre le Doc ! ");
            StartGame.AttendreTroisSeconde();


            do
            {
                Console.WriteLine("Joueur, appuyez sur Enter pour lancer les dés ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Des des = new Des();
                    int docHudson = des.LancerDes() * CastingVehicles.DocHudson.DrivingSkills * (int)(CastingVehicles.DocHudson.PercentageOfLuck * 100);
                    int mcQueen = des.LancerDes() * CastingVehicles.McQueen.DrivingSkills * (int)(CastingVehicles.McQueen.PercentageOfLuck * 100);

                    if (docHudson > mcQueen)
                    {
                        Console.WriteLine($"Avec un score de : {docHudson}, le Doc démarre en trombe et rattrape Flash ! Voulez-vous recommencer ? (1 pour Oui, 2 pour Non)");
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
                        Console.WriteLine($"Avec un score de : {mcQueen}, McQueen arrive à gérer le tournant quand soudain...");
                        StartGame.AttendreTroisSeconde();
                        Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} fini par se rater et finir dans le ravin et les cactus.");
                        StartGame.AttendreTroisSeconde();
                        Console.WriteLine($"Le doc arrive à son niveau et lui dit");
                        StartGame.AttendreTroisSeconde();
                        Console.ForegroundColor = CastingVehicles.DocHudson.Color;

                        Console.WriteLine($"{CastingVehicles.DocHudson.NameOfTheVehicle} : Tu n'est pas une vraie voiture de course");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();

                        Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} la {CastingVehicles.Martin.Brand} pickup fini par arriver pour aider McQueen à remonter du ravin grâce à son treuil.");
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
