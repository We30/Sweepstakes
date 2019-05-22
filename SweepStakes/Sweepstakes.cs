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
        int designatedNumber;
        string name;
        
        
        
        public Sweepstakes(string name)
        {
            winningNumber = 0;           
            designatedNumber = 0;
            this.name = name;
        }      
        
        

        public string PickWinner()
        {
            winningNumber = RandomNumber(1, designatedNumber);
            if(contestantsRoster.ContainsKey(winningNumber) == true)
            {
                return contestantsRoster[winningNumber].info;
            }
            return contestantsRoster[winningNumber].info;
        }

        public void PrintWinningContestantInfo()
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


        int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }
        public void RegisterContestant(Contestant contestant)
        {
            UserInterface.LastNameQuestion();
            contestant.lastName = Console.ReadLine();
            UserInterface.FirstNameQuestion();
            contestant.firstName = Console.ReadLine();
            UserInterface.EmailQuestion();
            contestant.email = Console.ReadLine();
            designatedNumber++;
            contestant.registrationNumber = designatedNumber;
            contestantsRoster.Add(contestant.registrationNumber, contestant);           
        }
    }
}
