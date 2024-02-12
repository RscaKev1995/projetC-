using System;
using System.Collections.Generic;
using static carsGame.Classes.CastingVehicles;

namespace carsGame.Classes
{
    public class PistonCup
    {
        public static void DayOfTheRace()
        {
            Console.Clear();
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Nous voici arrivés au jour tant attendu où {McQueen.NameOfTheVehicle}, {Chick.NameOfTheVehicle}, {King.NameOfTheVehicle} se disputent la Piston Cup !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();

            Console.WriteLine($"Commentateur : Mais où se cachait {McQueen.NameOfTheVehicle} donc depuis une semaine ?");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine($"Commentateur : Nous retrouvons donc nos trois concurrents pour une course qui s'annonce spectaculaire !");
            StartGame.AttendreTroisSeconde();

            bool utiliserPneusEtEssence = DemanderUtiliserPneusEtEssence();

            if (utiliserPneusEtEssence)
            {
                McQueen.MaxSpeed = 340;
            }
            else
            {
                McQueen.MaxSpeed = 330;
            }

            CommencerCourse();
        }

        public static bool DemanderUtiliserPneusEtEssence()
        {
            int reponse;
            do
            {
                Console.WriteLine("Joueur, voulez-vous utiliser les pneus de Luigi et Guido et l'essence de Fillmore ?");
                Console.WriteLine("1 pour oui, 2 pour non");
            } while (!int.TryParse(Console.ReadLine(), out reponse) || (reponse != 1 && reponse != 2));

            return reponse == 1;
        }

        public static void CommencerCourse()
        {
            const int toursTotal = 200;

            for (int tour = 1; tour <= toursTotal; tour++)
            {
                if (tour % 30 == 0 || tour == toursTotal)
                {
                    StartGame.AttendreTroisSeconde();

                    AfficherClassement(tour);
                }

                if (tour == 4)
                {
                    StartGame.AttendreTroisSeconde();

                    AfficherDialogueAu4emeTour();
                }
                else if (tour == 110)
                {
                    StartGame.AttendreTroisSeconde();

                    AfficherDialogueAu110emeTour();
                }
                else if (tour == 200)
                {
                    StartGame.AttendreTroisSeconde();

                    AfficherDialogueAu200emeTour();
                }
            }

        }

        public static void AfficherClassement(int tour)
        {
            Dictionary<VehicleRace, double> distances = new Dictionary<VehicleRace, double>();
            distances.Add(McQueen, McQueen.MaxSpeed * tour * 4);
            distances.Add(Chick, Chick.MaxSpeed * tour * 4);
            distances.Add(King, King.MaxSpeed * tour * 4);

            List<KeyValuePair<VehicleRace, double>> classement = TrierClassement(distances);

            Console.WriteLine($"Classement au tour {tour}:");
            int position = 1;
            foreach (KeyValuePair<VehicleRace, double> kvp in classement)
            {
                Console.WriteLine($"{position}. {kvp.Key.NameOfTheVehicle}");
                position++;
            }
            Console.WriteLine();
        }

        public static List<KeyValuePair<VehicleRace, double>> TrierClassement(Dictionary<VehicleRace, double> distances)
        {
            List<KeyValuePair<VehicleRace, double>> classement = new List<KeyValuePair<VehicleRace, double>>();
            foreach (KeyValuePair<VehicleRace, double> kvp in distances)
            {
                int index = 0;
                while (index < classement.Count && kvp.Value <= classement[index].Value)
                {
                    index++;
                }
                classement.Insert(index, kvp);
            }
            return classement;
        }

        public static void AfficherDialogueAu4emeTour()
        {
            Console.WriteLine("Nous sommes au 4ème tour et les pilotes sont en feux !");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{DocHudson.NameOfTheVehicle} : ça va petit tu t'en sors ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle} : Doc ? vous êtes venu ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{DocHudson.NameOfTheVehicle}: tu n'avais pas besoin d'un directeur technique ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{Martin.NameOfTheVehicle} : Vas y mon meilleur ami t'es le meilleur !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();

        }

        public static void AfficherDialogueAu110emeTour()
        {
            Console.WriteLine("Nous sommes au 110ème tour et le classement reste inchangé ! ");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle}: Doc , j'ai besoin d'un changement de pneus");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{DocHudson.NameOfTheVehicle} : Luigi Guido préparer vous !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.Guido.Color;

            Console.WriteLine($"{Guido.NameOfTheVehicle} : Guido est toujours prêt");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine("Commentateur : je n'ai jamais vu une equipe ou un seul membre de staff suffit pour le pit stop !");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Arrivée de McQueen au stand");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle} Guido à toi !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine("Guido change les 4 pneus en un temps record");
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.Guido.Color;

            Console.WriteLine($"{Guido.NameOfTheVehicle} : pit stop !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{DocHudson.NameOfTheVehicle} : Vas y petit tu es reparti !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle} Merci , je fonce !");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine("Commentateur : Incroyable passage au stand McQueen est rentré avant la stop car ! Il est toujours premier !");
            StartGame.AttendreTroisSeconde();

            StartGame.AttendreTroisSeconde();

        }

        public static void AfficherDialogueAu200emeTour()
        {
            Console.WriteLine("Commentateur : Nous sommes au dernier tour !");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Commentateur : mais que se passe t’il ? Chick pousse King qui se crash ! Quel catastrophe pour le King !");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Mcqueen dans sa tête : que dois-je faire ? aider le king ou gagner la piston cup ?");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Demande à l'utilisateur le choix 1 ou 2");
            int choix;
            do
            {
                Console.WriteLine("1. Gagner la Piston Cup");
                Console.WriteLine("2. Aider le King");
            } while (!int.TryParse(Console.ReadLine(), out choix) || (choix != 1 && choix != 2));

            if (choix == 1)
            {
                AfficherDialogueVictoire();
            }
            else
            {
                AfficherDialogueAideKing();
            }
        }

        public static void AfficherDialogueVictoire()
        {
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Commentateur : Quelle victoire de McQueen ! Mais quelle tristesse pour le King qui n'aura pas fini sa dernière course de sa carrière !");
        }

        public static void AfficherDialogueAideKing()
        {
            Console.WriteLine("Commentateur : Mais que fais McQueen qui s'arrête juste avant la ligne d'arrivée ! Il fait marche arriere !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.DocHudson.Color;

            Console.WriteLine($"{DocHudson.NameOfTheVehicle} : Flash tu fais quoi ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine("Commentateur : McQueen va vers le King , pendant que Chick vient de remporter la Piston Cup !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();
            Console.ForegroundColor = CastingVehicles.King.Color;

            Console.WriteLine($"{King.NameOfTheVehicle}  : Bah qu’est-ce que tu fais là petit ?");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle} : J’estime que le King doit terminer sa dernière course.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.King.Color;

            Console.WriteLine($"{King.NameOfTheVehicle} : Tu viens de perdre la Piston Cup, et tu le sais.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.ForegroundColor = CastingVehicles.McQueen.Color;

            Console.WriteLine($"{McQueen.NameOfTheVehicle} : Bah, comme l’a dit un jour un ami coureur particulièrement grincheux, ce n’est qu’une coupe vide.");
            StartGame.AttendreTroisSeconde();
            Console.ResetColor();
            Console.WriteLine("Commentateur : Darell, est ce que le réglement autorise un concurant à en pousser un autre ?");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();

            Console.WriteLine("Commentateur 2 : Oh il ne le pousse pas vraiment, il lui donne juste un petit coup de parechoc.");
            StartGame.AttendreTroisSeconde();
            Console.WriteLine("Commentateur : McQueen fini troisième en poussant le king à la deuxieme place ! Incroyable choix de McQueen qui vient de perdre la course !");
            StartGame.AttendreTroisSeconde();
            StartGame.AttendreTroisSeconde();

        }


    }
}
