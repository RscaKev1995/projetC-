using System;
using static carsGame.Classes.CastingVehicles;

namespace carsGame.Classes
{
    public class DayBeforeOfRace
    {
        public static void McQueenLeaveRadiatorSpring()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Deux jours passèrent quand un matin, {CastingVehicles.McQueen.NameOfTheVehicle} est réveillé par le bruit d'un hélicoptère");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Flash sort de son hôtel, et voit pleins de papparazzi arriver et l'un deux lui demanda si il a été kidnappé");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Non du tout, comment vous m'avez retrouvé ? ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.Mack.Color;
            Console.WriteLine($"{CastingVehicles.Mack.NameOfTheVehicle}: {CastingVehicles.McQueen.NameOfTheVehicle} enfin je te retrouve ! Allez vient on part pour la piston Cup !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine($"Flash chercha {CastingVehicles.Martin.NameOfTheVehicle} ou {CastingVehicles.Sally.NameOfTheVehicle} qui l'appelaient mais trop de journalistes arrivèrent devant lui.");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.Mack.Color;
            Console.WriteLine($"{CastingVehicles.Mack.NameOfTheVehicle}: Allez c'est parti l'éclair !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine("Flash est enlevé de force");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Mack.Color;

            Console.WriteLine($"{CastingVehicles.Mack.NameOfTheVehicle}: Direction la Piston Cup !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Sally.Color;

            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle}: Doc, c'est vous qui avez prévenu les médias ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{CastingVehicles.DocHudson.NameOfTheVehicle}: C'est bien mieux pour notre petite ville.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Sally.Color;

            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle}: Mieux pour la ville ou pour vous ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} s'en alla de Radiator Spring");


        }
    }
}
