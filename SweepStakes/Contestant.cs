using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int registrationNumber { get; set; }
        public string info { get { return firstName +"\n"+ lastName +"\n"+ email; } }
      
    }
}
