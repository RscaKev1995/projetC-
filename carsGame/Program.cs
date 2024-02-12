using System.IO;
using carsGame.Classes;

namespace carsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            StartGame.Start();
            SecondPart.Second();
            PuirsuitSheriff.ExecutePursuit();
            Tribunal.TribunalHappening();
            FirstRaceDoc.RaceDoc();
            MartinRace.RaceMartin();
            SallyAndSecondRaceWithDoc.SecondRace();
            DayBeforeOfRace.McQueenLeaveRadiatorSpring();
            PistonCup.DayOfTheRace();
            End.EndOfTheGame();

        }
    }
}