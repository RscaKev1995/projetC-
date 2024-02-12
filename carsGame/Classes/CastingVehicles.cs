using System;

namespace carsGame.Classes
{
    public static class CastingVehicles
    {
        public static VehicleRace McQueen = new VehicleRace("McQueen", 2006, "Dodge", 20, 0.75, ConsoleColor.Red) { MaxSpeed = 330 };
        public static VehicleRace Chick = new VehicleRace("Chick", 1981, "Nascar", 20, 0.75, ConsoleColor.Green) { MaxSpeed = 330 };
        public static VehicleRace King = new VehicleRace("King", 1970, "Plymouth", 20, 0.75, ConsoleColor.DarkBlue) { MaxSpeed = 329 };
        public static VehicleRace Sheriff = new VehicleRace("Sheriff", 1949, "Mercury", 18, 0.85, ConsoleColor.Black) { MaxSpeed = 130 };
        public static VehicleRace Moissoneuse = new VehicleRace("Frank la moissoneuse-batteuse", 2006, "Metroactual", 20, 0.35, ConsoleColor.Gray) { MaxSpeed = 70 };
        public static VehicleRace DocHudson = new VehicleRace("Doc Hudson", 1951, "Hudson", 20, 0.65, ConsoleColor.DarkGray) { MaxSpeed = 270 };

        public static VehicleFriend Sally = new VehicleFriend("Sally", 2002, "Porsche", ConsoleColor.Cyan);
        public static VehicleFriend Martin = new VehicleFriend("Martin", 1954, "Chevrolet", ConsoleColor.DarkMagenta);
        public static VehicleFriend Luigi = new VehicleFriend("Luigi", 1959, "Fiat 500", ConsoleColor.Yellow);
        public static VehicleFriend Guido = new VehicleFriend("Guido", 1959, "Alza Tutto", ConsoleColor.Gray);
        public static VehicleFriend Mack = new VehicleFriend("Mack", 2000, "Volvo", ConsoleColor.DarkRed);
        public static VehicleFriend Fillmore = new VehicleFriend("Fillmore", 1961, "Volkswagen", ConsoleColor.Green);
        public static VehicleFriend Tex = new VehicleFriend("Tex", 1975, "Cadillac", ConsoleColor.DarkGreen);
    }
}
    