using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        int winningNumber;
        int rosterCount;
        Contestant contestant;
        
        public Sweepstakes()
        {
            winningNumber = 0;
            rosterCount = 0;
        }
        public static Sweepstakesasd(string name)
        {

        }
        

        public string PickWinner()
        {
            winningNumber = RandomNumber(1, rosterCount);
            return contestantsRoster[winningNumber];
            
        }

        public void PrintContestantInfo()
        {
            Console.WriteLine(contestantsRoster[winningNumber]);
        }

        Dictionary<int, string> contestantsRoster = new Dictionary<int, string>()
        {

        };


        

        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }
        public void RegisterContestant(Contestant contestant)
        {

            Console.WriteLine("What is your Last Name?");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("What is your First Name?");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("What is your Email?");
            contestant.email = Console.ReadLine();
            contestant.registrationNumber = RandomNumber(1, 1000);
            contestantsRoster.Add(contestant.registrationNumber, contestant.lastName);
            rosterCount++;
        }
    }
}
