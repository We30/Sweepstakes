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
            Contestant shawn = new Contestant();
            Contestant domino = new Contestant();
            Contestant ender = new Contestant();
            Contestant bre = new Contestant();
            thing.WhichManager();
            thing.manager.InsertSweepstakes(gotmilk);
            thing.manager.InsertSweepstakes(gotmilk1);
            thing.manager.InsertSweepstakes(gotmilk2);
            gotmilk2.RegisterContestant(shawn);
            thing.manager.InsertSweepstakes(gotmilk3);
            thing.manager.InsertSweepstakes(gotmilk2);
            thing.manager.GetSweepstakes();
            Console.ReadLine();
        }
    }
}
