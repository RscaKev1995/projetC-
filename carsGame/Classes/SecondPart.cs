using System;
using static carsGame.Classes.CastingVehicles;

namespace carsGame.Classes
{
    public class SecondPart
    {
        public static void Second()
        {
            Console.Clear();
          


            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"En route vers le circuit de la Piston Cup à bord du camion et ami {Mack.NameOfTheVehicle}");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Flash demande à Mack de ne pas faire de pause afin d'arriver le premier au Circuit");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("McQueen se réveille et se retrouve sur l'autoroute, sans phare étant une voiture de circuit et il est déboussolé");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"Où suis-je ? Où est Mack ? Comment est-ce que j'ai pu perdre cet énorme camion {Mack.Brand} ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Quelle route je prend ? À gauche (tapez 1) ou à droite (tapez 2) ? ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();



            string userInput = Console.ReadLine();


            bool correctChoice = false;


            while (!correctChoice)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine($"Flash voit de la lumière au loin, ça doit sûrement être l'autoroute. Je vais pouvoir retrouver {Mack.NameOfTheVehicle} et pouvoir dormir.");
                        correctChoice = true;
                        break;
                    case "2":
                        Console.WriteLine("Flash décide de prendre à droite, et conduit jusqu'à se retrouver au bord d'une falaise. Il fait donc demi-tour.");
                        StartGame.AttendreTroisSeconde();
                        Console.ForegroundColor = CastingVehicles.McQueen.Color;

                        Console.WriteLine($"Quelle route je prend ? À gauche (tapez 1) ou à droite (tapez 2) ? ");
                        Console.ResetColor();

                        userInput = Console.ReadLine();
                        break;  
                    default:
                        Console.WriteLine("Choix non valide. Veuillez taper 1 pour gauche ou 2 pour droite.");
                        userInput = Console.ReadLine();
                        break;
                }
            }
            StartGame.AttendreTroisSeconde();

            Console.WriteLine("La lumière n'est pas l'autoroute , on dirait une ville ? ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Flash percute un piquet et va se percuter à une façade... ");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"En revenant à lui, il voit de la lumière bleu et rouge, qu'est-ce donc ? Voilà le {Sheriff.NameOfTheVehicle} , Flash démarre en trombe !");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("C'est le début d'une course poursuite !");

        }
    }
}
