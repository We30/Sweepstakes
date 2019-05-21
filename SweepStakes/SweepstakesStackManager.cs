using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {

            stack.Push(sweepstakes);
            
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return stack.Pop();
            
        }
    }
}
