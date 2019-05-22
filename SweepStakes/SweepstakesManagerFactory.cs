using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesManagerFactory
    {
        ISweepstakesManager manager;
        public SweepstakesManagerFactory()
        {
            
        }
        public ISweepstakesManager WhichManager(string response)
        {
            switch (response)
            {
                case "Stack":
                    manager = new SweepstakesStackManager();
                    return manager;
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    return manager;
                default:
                    UserInterface.NotAValidOption();
                    return WhichManager(response);
                    
            }
        }
    }
}
