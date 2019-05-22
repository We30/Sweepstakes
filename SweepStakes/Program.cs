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
            SweepstakesManagerFactory smf = new SweepstakesManagerFactory();

            //var manager = smf.WhichManager("queue");
            UserInterface.WhichManagerQuestion();
            MarketingFirm thing = new MarketingFirm(smf.WhichManager(UserInterface.GetResponse()));
            Sweepstakes gotmilk = new Sweepstakes("got milk");
            Sweepstakes gotmilk1 = new Sweepstakes("got milk1");
            Sweepstakes gotmilk2 = new Sweepstakes("got milk2");
            Sweepstakes gotmilk3 = new Sweepstakes("got milk3");
            Contestant shawn = new Contestant();
            Contestant domino = new Contestant();
            Contestant ender = new Contestant();
            Contestant bre = new Contestant();       
            thing.manager.InsertSweepstakes(gotmilk);
            thing.manager.InsertSweepstakes(gotmilk1);
            thing.manager.InsertSweepstakes(gotmilk2);
            gotmilk2.RegisterContestant(shawn);
            thing.manager.InsertSweepstakes(gotmilk3);
            thing.manager.InsertSweepstakes(gotmilk2);
            Sweepstakes s =  thing.manager.GetSweepstakes();
            Console.ReadLine();
        }
    }
}
