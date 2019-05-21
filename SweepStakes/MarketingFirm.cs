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
        public MarketingFirm()
        {
            response = null;
        }
        public void Run()
        {
            WouldYouLikeToEnter();

        }
        void WouldYouLikeToEnter()
        {
            UserInterface.WouldYouLikeToEnterQuestion();
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
