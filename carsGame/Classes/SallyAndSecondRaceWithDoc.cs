using System;
using static carsGame.Classes.CastingVehicles;

namespace carsGame.Classes
{
    public class SallyAndSecondRaceWithDoc
    {
        public static void SecondRace()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Le lendemain à l'aube , {CastingVehicles.McQueen.NameOfTheVehicle} termina les réparations de la route.");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle} vena reveiller {CastingVehicles.McQueen.NameOfTheVehicle} pour lui proposer une balade dans la vallée.");


            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Sally.Color;

            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle} : Aller suis moi... ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine("Flash suis Sally sur les routes désertes et sinueuse de la vallée ... ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Ils passent un superbe moment et finisse par faire une course ou {CastingVehicles.Sally.NameOfTheVehicle} apprend beaucoup d'astuce de conduite.");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
          

            CastingVehicles.McQueen.DrivingSkills = 40;
            CastingVehicles.McQueen.PercentageOfLuck = 0.95;
            
            Console.WriteLine($"Les aptitudes de McQueen ont évoluées !");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Sally.Color;

            Console.WriteLine($"{Sally.NameOfTheVehicle} : Bon il est temps de rentrer, tu as une revanche à prendre contre{CastingVehicles.DocHudson.NameOfTheVehicle}");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine($"Arrivée au circuit de terre ou {CastingVehicles.McQueen.NameOfTheVehicle} avait perdu contre le doc... ");

            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{CastingVehicles.DocHudson.NameOfTheVehicle} : Alors petit, prêt à perdre de nouveau ? ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Calmez-vous l'ancêtre, il n'y aura qu'un seul gagnant aujourd'hui et ça sera moi ! ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Martin.Color;

            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} : Allez {CastingVehicles.McQueen.NameOfTheVehicle} , mon meilleur ami tu vas gagné ! ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Sally.Color;

            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle}: Prêt les garçons ? ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle}: C'est partit ! ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Fillmore.Color;

            Console.WriteLine($"{CastingVehicles.Fillmore.NameOfTheVehicle}: {CastingVehicles.McQueen.NameOfTheVehicle} est bien parti pour l'emporter ! ");
            StartGame.AttendreTroisSeconde(); 
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Luigi.Color;

            Console.WriteLine($"{CastingVehicles.Luigi.NameOfTheVehicle}: Ca c'est uno voiture de course ! ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();


            do
            {
                Console.WriteLine("Joueur, appuyez sur Enter pour lancer les dés ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Des des = new Des();
                    int docHudsonSecondRace = des.LancerDes() * CastingVehicles.DocHudson.DrivingSkills * (int)(CastingVehicles.DocHudson.PercentageOfLuck * 100);
                    int mcQueenSecondRace = des.LancerDes() * CastingVehicles.McQueen.DrivingSkills * (int)(CastingVehicles.McQueen.PercentageOfLuck * 100);

                    if (docHudsonSecondRace > mcQueenSecondRace)
                    {
                        Console.WriteLine($"Avec un score de : {docHudsonSecondRace}, le Doc bat de nouveau Flash ! Voulez-vous recommencer ? (1 pour Oui, 2 pour Non)");
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
                        Console.WriteLine($"Avec un score de : {mcQueenSecondRace}, McQueen arrive à gérer le tournant à la perfection");
                        StartGame.AttendreTroisSeconde();
                        Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} fini par franchir la ligne d'arrivée avant le doc.");
                        StartGame.AttendreTroisSeconde();
                        Console.WriteLine($"Le doc arrive à son niveau et lui dit");
                        StartGame.AttendreTroisSeconde();
                        Console.ForegroundColor = CastingVehicles.DocHudson.Color;

                        Console.WriteLine($"{CastingVehicles.DocHudson.NameOfTheVehicle}: Enfin tu montres ce que tu vaux petit, je suis fier de toi !");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();
                        Console.ForegroundColor = CastingVehicles.Martin.Color;

                        Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} : Mon meilleur ami c'est le meilleur ! ");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();

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
