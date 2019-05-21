using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm thing = new MarketingFirm();
            Sweepstakes gotmilk = new Sweepstakes();
            Sweepstakes gotmilk1 = new Sweepstakes();
            Sweepstakes gotmilk2 = new Sweepstakes();
            Sweepstakes gotmilk3 = new Sweepstakes();
            thing.stack.InsertSweepstakes(gotmilk);
            thing.stack.InsertSweepstakes(gotmilk1);
            thing.stack.InsertSweepstakes(gotmilk2);
            thing.stack.InsertSweepstakes(gotmilk3);
            thing.queue.InsertSweepstakes(gotmilk);
            thing.stack.GetSweepstakes();
            Console.ReadLine();
        }
    }
}
