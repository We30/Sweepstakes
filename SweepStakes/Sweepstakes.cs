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
        int maxPeopleInSweepstakes;
        SweepstakesStackManager stack;
        SweepstakesQueueManager queue;
        
        
        
        public Sweepstakes()
        {
            winningNumber = 0;
            rosterCount = 0;
            maxPeopleInSweepstakes = 10;
            stack = new SweepstakesStackManager();
            queue = new SweepstakesQueueManager();
            
        }
        /*public static Sweepstakesasd(string name)
        {

        }*/
        

        public string PickWinner()
        {
            winningNumber = RandomNumber(1, maxPeopleInSweepstakes);
            if(contestantsRoster.ContainsKey(winningNumber) == true)
            {
                return contestantsRoster[winningNumber].info;
            }
            else { return PickWinner(); }
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestantsRoster[winningNumber].info);
        }

        Dictionary<int, Contestant> contestantsRoster = new Dictionary<int, Contestant>()
        {

        };
        public void PrintDictionary() {           
                foreach (KeyValuePair<int, Contestant> pair in contestantsRoster)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            };
        }


        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }
        public void RegisterContestant(Contestant contestant)
        {

            
            Console.WriteLine("What is the Last Name?");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("What is the First Name?");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("What is the Email?");
            contestant.email = Console.ReadLine();
            contestant.registrationNumber = RandomNumber(1, maxPeopleInSweepstakes);
            contestantsRoster.Add(contestant.registrationNumber, contestant);
            rosterCount++;
            
        }
    }
}
