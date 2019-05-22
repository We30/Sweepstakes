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
            UserInterface.WhichManager();
                string response = Console.ReadLine();
                switch (response)
                {
                    case "Stack":
                        manager = new SweepstakesStackManager();
                        break;
                    case "Queue":
                        manager = new SweepstakesQueueManager();
                        break;
                    default:
                    UserInterface.NotAValidOption();
                        WhichManager();
                        break;

                }            
        }
        


    }
}
