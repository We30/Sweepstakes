using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        string response;
        Sweepstakes sweepstakes;
        public MarketingFirm()
        {
            response = null;
            sweepstakes = new Sweepstakes();
        }
        public void Run()
        {
            WouldYouLikeToEnter();
            sweepstakes.RegisterContestant();
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo();
        }
        void WouldYouLikeToEnter()
        {
            UserInterface.WouldYouLikeToEnterQuestion();
            response = Console.ReadLine();
            switch (response)
            {
                case "yes":
                    //asdasdasd
                    break;
                case "no":
                    //asdasd
                    break;
                default:
                    UserInterface.NotAnOption();
                    WouldYouLikeToEnter();
                    break;
            }
        }

    }
}
