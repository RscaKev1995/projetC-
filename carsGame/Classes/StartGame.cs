using System;
using System.Net.NetworkInformation;
using System.Threading;
using static carsGame.Classes.CastingVehicles;


namespace carsGame.Classes
{
    public class StartGame
    {
        public static void Start()
        {
            
            AfficherBienvenue();

            string choix;
            do
            {
                Console.Write("Voulez-vous lancer la partie ? (1 pour oui, 2 pour non): ");
                choix = Console.ReadLine();

                if (choix != "1" && choix != "2")
                {
                    Console.WriteLine("Veuillez entrer une valeur numérique de 1 ou 2 uniquement.");
                }
                else if (choix == "2")
                {
                    Console.WriteLine("Vous avez choisi de ne pas lancer la partie.");
                    Console.Write("Voulez-vous lancer la partie ? (1 pour oui, 2 pour non): ");
                    choix = Console.ReadLine();
                }

            } while (choix != "1" && choix != "2");

            if (choix == "1")
            {
                Console.WriteLine("Début de la partie !");
                Console.ForegroundColor = CastingVehicles.McQueen.Color;
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Bon, allons-y. Concentration.");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Rapide, je suis rapide.");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Un vainqueur, quarante-deux perdants. J’en fait qu’une bouchée à mon petit déjeuner des perdants.");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Oh, en parlant de petit-déjeuner, un bon p’tit dej’ ça me ferait p’tet’ du bien.");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Nan nan nan concentration.");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Vitesse.");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Plus rapide que la lumière,");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Je suis Flash McQueen !");
                AttendreTroisSeconde();
                Console.WriteLine($"{Mack.NameOfTheVehicle}  : (Boum boum boum) Oh Flash, t’es prêt ?");
                AttendreTroisSeconde();
                Console.WriteLine($"{McQueen.NameOfTheVehicle} : Oh oui, Flash est prêt !");
                AttendreTroisSeconde();
                Console.ResetColor();

                Console.WriteLine("C'est un début de course tonitruant ! Nos bolides sont en formes aujourd'hui !");

                AttendreTroisSeconde();
                Console.WriteLine("Appuyez sur Enter pour lancer les dés pour influencer Flash");
                do
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Enter)
                        break;

                    Console.WriteLine("Veuillez appuyer uniquement sur Enter pour lancer les dés.");
                } while (true);

                Des des = new Des();
                int resultat = des.LancerDes();

                Console.WriteLine($"Résultat du lancer de dés : {resultat}");

                if (resultat > 2)
                {
                    Console.WriteLine($"Quelle course de Flash McQueen qui ne perd pas de temps à passer à la première place devant {Chick.NameOfTheVehicle} la fameuse voiture {Chick.Brand} de {Chick.DateConstruct} !");
                }
                else
                {
                    Console.WriteLine($"McQueen a du mal aujourd'hui mais rattrape son retard sur {King.NameOfTheVehicle} la {King.Brand} de {King.DateConstruct}!");
                }
                AttendreTroisSeconde();
                Console.WriteLine("199 tours déjà de bouclés !");
                AttendreTroisSeconde();
                Console.WriteLine("Il reste 1 seul tour et McQueen est toujours en tête !");



                AttendreTroisSeconde();
                Console.WriteLine("Mais que se passe t’il ? McQueen a crever ! Il vient de perdre deux de ces pneus ! ");
                AttendreTroisSeconde();
                Console.WriteLine("Cela change la donne !");
                AttendreTroisSeconde();
                Console.WriteLine("Qui va l’emporter ?");
                AttendreTroisSeconde();
                Console.WriteLine("Suspence ! La ligne d'arrivée est proche ! ");
                AttendreTroisSeconde();
                Console.WriteLine("Et c’est terminé ! Les trois bolides ont l’air d’avoir franchit la piste en même temps !  ");
                AttendreTroisSeconde();
                Console.WriteLine("La direction annonce que c’est un match nul !   ");
                AttendreTroisSeconde();
                Console.WriteLine("La course menant a la victoire de la Piston Cup se jouera donc dans deux semaines !");
                AttendreTroisSeconde();
                AttendreTroisSeconde();


            }
            else if (choix == "2")
            {
                AfficherBienvenue();
                Console.WriteLine("Vous avez choisi de ne pas lancer la partie.");
            }
        }

        static void AfficherBienvenue()
        {
            Console.WriteLine("Bienvenue dans le jeu console C# Cars, jeu basé sur des lancers de dés qui va parcourir l'histoire de Cars 1 de Disney Pixar.");
        }

        public static void AttendreTroisSeconde()
        {
            Thread.Sleep(3000);
        }
    }
}