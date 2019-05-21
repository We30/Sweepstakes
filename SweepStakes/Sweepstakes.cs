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
        public string name;
        
        public Sweepstakes()
        {
            winningNumber = 0;
            rosterCount = 0;
            maxPeopleInSweepstakes = 10;
            name = "random";
        }
        /*public static Sweepstakesasd(string name)
        {

        }*/
        

        public string PickWinner()
        {
            winningNumber = RandomNumber(1, maxPeopleInSweepstakes);
            if(contestantsRoster.ContainsKey(winningNumber) == true)
            {
                return contestantsRoster[winningNumber];
            }
            else { return PickWinner(); }
            
        }

        public void PrintContestantInfo()
        {
            Console.WriteLine(contestantsRoster[winningNumber]);
        }

        Dictionary<int, string> contestantsRoster = new Dictionary<int, string>()
        {

        };
        public void PrintDictionary() {           
                foreach (KeyValuePair<int, string> pair in contestantsRoster)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            };
        }


        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }
        public void RegisterContestant()
        {
            
            Contestant person = new Contestant();
            Console.WriteLine("What is your Last Name?");
            person.lastName = Console.ReadLine();
            Console.WriteLine("What is your First Name?");
            person.firstName = Console.ReadLine();
            Console.WriteLine("What is your Email?");
            person.email = Console.ReadLine();
            person.registrationNumber = RandomNumber(1, maxPeopleInSweepstakes);
            contestantsRoster.Add(person.registrationNumber, person.lastName);
            rosterCount++;
            
        }
    }
}
