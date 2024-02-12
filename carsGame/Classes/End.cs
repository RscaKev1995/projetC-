using System;
using System.Collections.Generic;
using static carsGame.Classes.CastingVehicles;

namespace carsGame.Classes
{
    public class End
    {
        public static void EndOfTheGame()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Quelques temps après la course...");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Mack.Color;

            Console.WriteLine($"{Mack.NameOfTheVehicle}: Bravo c'est une très belle défaite ! ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{DocHudson.NameOfTheVehicle} : Tu es bourré de qualités petit.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle}: Merci doc.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.Tex.Color;

            Console.WriteLine($"{Tex.NameOfTheVehicle}: Flash, tu peux venir s'il te plait, j'aimerais te parler.");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"{Tex.NameOfTheVehicle}: C'est une course magnifique que tu nous a offert aujourd'hui !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"{Tex.NameOfTheVehicle}: Est-ce que tu veux devenir le nouveau visage de Dinoco ? ");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle}: Mais j'ai pas gagné...");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.Tex.Color;

            Console.WriteLine($"{Tex.NameOfTheVehicle}: Flash, l'esprit de la course c'est bien autre chose que la seule victoire. ");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();


            Console.WriteLine("Après quelques instant de réflexion...");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle}: Merci beaucoup monsieur {Tex.NameOfTheVehicle}, mais ce sont les gens de chez Rusties qui m'ont mis le pied à l'étrier.");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"{McQueen.NameOfTheVehicle}: Je vais rester avec eux.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.Tex.Color;

            Console.WriteLine($"{Tex.NameOfTheVehicle}: Très bien, je respecte ça. Cela dis si je peux faire quelques choses pour toi, n'hésite pas surtout hein.");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle}: D'accord, je vous remercie c'est très gentil à vous.");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"{McQueen.NameOfTheVehicle}: Attendez, je crois qu'il me vient une idée...");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine("Quelques jours plus tard à Radiator Spring...");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Martin.Color;

            Console.WriteLine($"{Martin.NameOfTheVehicle}: Wahouuuu ! Je vole ! Wahouuuu ! Je me régale comme une tornade dans un camping ! Wahouuuu !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

            Console.WriteLine($"L'histoire, se finit sur {McQueen.NameOfTheVehicle} et {Sally.NameOfTheVehicle} qui partent en promenade en amoureux...");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Fin du jeux... Rendez-vous très prochainement pour Cars 2 !");
            StartGame.AttendreTroisSeconde();


        }


    }
}
