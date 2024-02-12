using System;
using static carsGame.Classes.CastingVehicles;
namespace carsGame.Classes
{
    public class Tribunal
    {
        public static void TribunalHappening()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Le lendemain matin {CastingVehicles.McQueen.NameOfTheVehicle} se réveille...");
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.McQueen.Color;
            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle} : Un sabot ? Mais pourquoi on m’a mis un sabot ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Martin.Color;
            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle}: Haha t’es un marrant toi, je sens qu’on va s’entendre. J’m’appelle Martin.");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.McQueen.Color;
            Console.WriteLine($"{McQueen.NameOfTheVehicle}:{CastingVehicles.Martin.NameOfTheVehicle} ?");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.Martin.Color;
            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle}: Oui, comme Aston Martin, mais sans Aston. Et toi comment tu t’appelles?");
            StartGame.AttendreTroisSeconde();

            Console.WriteLine($"{CastingVehicles.Martin.NameOfTheVehicle}: Ah oui au fait, je serai ton avocat, mais je ne suis pas avocat ! Et le {CastingVehicles.DocHudson.NameOfTheVehicle} nous attend au tribunal !");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.WriteLine("Arrivée au tribunal...");
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.Sheriff.Color;
            Console.WriteLine($"{CastingVehicles.Sheriff.NameOfTheVehicle}: Bienvenue au procès de l'accusé nommé Flash McQueen, on est ici pour juger son crime contre notre bonne vieille ville de Radiator Spring. Faites entrer l'accusé {CastingVehicles.McQueen.NameOfTheVehicle} et notre bon vieux {CastingVehicles.DocHudson.NameOfTheVehicle}");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.DocHudson.Color;
            Console.WriteLine($"{CastingVehicles.DocHudson.NameOfTheVehicle}: Une voiture de course ? C'est pas vrai ...  Dégagez le moi d'ici l'affaire est close");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.WriteLine($"Une porte s'ouvrit, une {CastingVehicles.Sally.Brand} de {CastingVehicles.Sally.DateConstruct} arriva ");
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.Sally.Color;
            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle}: Bonjour, je m'appelle {CastingVehicles.Sally.NameOfTheVehicle} et je suis l'avocate de la ville.");
            StartGame.AttendreTroisSeconde();

            Console.WriteLine($"{CastingVehicles.Sally.NameOfTheVehicle}: Il est hors de question qu'il s'en sorte ainsi, j'exige qu'il répare au moins notre route ! ");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.WriteLine("Sous les hurlements de la foule, la sentence fut sans appel quand le Doc intervena.");
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.DocHudson.Color;
            Console.WriteLine($"{CastingVehicles.DocHudson.NameOfTheVehicle}: Le bolide, si tu me bats à la course, je t'acquitte de ta peine");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();

            Console.ForegroundColor = CastingVehicles.McQueen.Color;
            Console.WriteLine($"{CastingVehicles.McQueen.NameOfTheVehicle}: C'est gagné d'avance vieillard ! ");
            Console.ResetColor();
            StartGame.AttendreTroisSeconde();
        }
    }
}
