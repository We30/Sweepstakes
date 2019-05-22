using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        
        public static void WhichManagerQuestion()
        {
            Console.WriteLine("Which manager would you like to use? 'Stack' or 'Queue'");
        }

        public static void NotAValidOption()
        {
            Console.WriteLine("That was not a valid option. Please Try again.");
        }

        public static void LastNameQuestion()
        {
            Console.WriteLine("What is the Last Name?");
        }

        public static void FirstNameQuestion()
        {
            Console.WriteLine("What is the First Name?");
        }

        public static void EmailQuestion()
        {
            Console.WriteLine("What is the Email?");
        }

        public static string GetResponse()
        {
            string response = Console.ReadLine();
            return response;
        }
    }
}
