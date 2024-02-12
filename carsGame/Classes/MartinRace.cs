using System;
using static carsGame.Classes.CastingVehicles;
namespace carsGame.Classes
{
    public class MartinRace
    {
        public static void RaceMartin()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Le lendemain matin, {CastingVehicles.McQueen.NameOfTheVehicle} travailla péniblement à réparer la route");
            StartGame.AttendreTroisSeconde();
            
            Console.WriteLine($"La soirée venue , {CastingVehicles.Martin.NameOfTheVehicle} arriva prêt de McQueen ");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Martin.Color;

            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} :Tu viens en ronde de nuit avec moi ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Et en quoi ça consiste ?  ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.Martin.Color;

            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} :Tu verras...");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Quelques minutes de routes plus tard,{CastingVehicles.Martin.NameOfTheVehicle} et {CastingVehicles.McQueen.NameOfTheVehicle}  arrivent devant des tracteurs endormis. ");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Martin.Color;
            Console.ResetColor();
            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} : Tu es prêt ? ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Pour ?  ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} klaxonne de toute ces forces, ce qui reveilla le tracteur devant eux");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : J'ai mieux que ça attend écoute ! ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} fait rugir son moteur V8 {CastingVehicles.McQueen.Brand}");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Un silence s'en suivi puis d'un coup tout les tracteurs se reveilla un après l'autre");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Quand tout d'un coup un énorme rugissement rettentit");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Martin.Color;

            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} : Il est temps d'y aller, {CastingVehicles.Moissoneuse.NameOfTheVehicle} arrive ! ");

            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : {CastingVehicles.Moissoneuse.NameOfTheVehicle} ? ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine("Une moissoneuse-batteuse énorme arriva à toute vitesse, il est temps pour Flash de partir !");
            StartGame.AttendreTroisSeconde();
            do
            {
                Console.WriteLine("Joueur, appuyez sur Enter pour lancer les dés ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Des des = new Des();
                    int moissoneuse = des.LancerDes() * CastingVehicles.Moissoneuse.DrivingSkills * (int)(CastingVehicles.Moissoneuse.PercentageOfLuck * 100);
                    int mcQueenDeux = des.LancerDes() * CastingVehicles.McQueen.DrivingSkills * (int)(CastingVehicles.McQueen.PercentageOfLuck * 100);

                    if (moissoneuse > mcQueenDeux)
                    {
                        Console.WriteLine($"Avec un score de : {moissoneuse}, la moissoneuse rattrape Flash en deux temps trois mouvements de roues ! Voulez-vous recommencer ? (1 pour Oui, 2 pour Non)");
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
                        Console.WriteLine($"Avec un score de : {mcQueenDeux}, McQueen arrive à s'échapper de peu de {CastingVehicles.Moissoneuse.NameOfTheVehicle} !");
                        StartGame.AttendreTroisSeconde();
                        Console.ForegroundColor = CastingVehicles.McQueen.Color;

                        Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : C'était moins une !");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();

                        Console.ForegroundColor = CastingVehicles.Martin.Color;

                        Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} : C'était génial tu veux dire ! C'est l'éclate !");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();
                        Console.ForegroundColor = CastingVehicles.McQueen.Color;

                        Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : On a pas la même vision de l'amusement");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();

                        Console.ForegroundColor = CastingVehicles.Martin.Color;

                        Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle} : Avec mon meilleur ami c'est toujours génial !");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();
                        Console.ForegroundColor = CastingVehicles.McQueen.Color;

                        Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Meilleur ami ? ");
                        StartGame.AttendreTroisSeconde();
                        Console.ResetColor();

                        Console.WriteLine("Les deux voitures continue leurs routes vers Radiator Spring...");
                        StartGame.AttendreTroisSeconde();
                        Console.ForegroundColor = CastingVehicles.McQueen.Color;

                        Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Je vais aller me reposer, à demain Martin. ");
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
