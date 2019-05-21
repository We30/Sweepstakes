using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {

            
            queue.Enqueue(sweepstakes);
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            
            return queue.Dequeue();
        }
    }
}
