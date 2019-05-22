using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        
        public ISweepstakesManager manager;



        public MarketingFirm()
        {           
            manager = null;
        }
        
        public void WhichManager()
        {           
                Console.WriteLine("Which manager would you like to use? 'Stack' or 'Queue'");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "Stack":
                        manager = new SweepstakesStackManager();
                        break;
                    case "Queue":
                        manager = new SweepstakesStackManager();
                        break;
                    default:
                        Console.WriteLine("That was not a valid option. Please Try again.");
                        WhichManager();
                        break;

                }            
        }
        


    }
}
