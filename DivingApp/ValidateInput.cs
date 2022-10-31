using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class ValidateInput
    {
        public static string validateInputLevel(string input)
        {
            if (input == "1")
            {
                var answer = "Open Water";
                return answer;
            }
            else if (input == "2")
            {
                var answer = "Advance";
                return answer;
            }
            else if (input == "3")
            {
                var answer = "DiveMaster";
                return answer;
            }
            else
            {
                return "invalid answer";
            }
        }

        public static string validateInputTank(string input)
        {
            if (input == "1")
            {
                input = "single tank";
                return input;
            }
            else if (input == "2")
            {
                input = "double tanks";
                return input;
            }

            else
            {
                return "invalid";
            }
        }

        public static string validateInputPressure(string input)
        {
            if (input == "1")
            {
                var answer = "200";
                return answer;
            }
            else if (input == "2")
            {
                var answer = "300";
                return answer;
            }

            else
            {
                return "invalid";
            }
        }

        public static void  validateInputTeam(string input)
        {
            if (input == "1")
            {
                Console.WriteLine("You chose team 1, press enter to see who from this team can do the dive");
                Console.ReadLine();
                foreach (var teamMember in App.team1)
                {
                   
                    var depth = App.ClientDive.Depth;
                    var timeMnts = App.ClientDive.TimeMnts;
                    TheDive checkIfCan = new TheDive(teamMember, depth,timeMnts);
                    
                }
               
            }
            else if (input == "2")
            {
                Console.WriteLine("You chose team 2, press enter to see who from this team can do the dive");
                Console.ReadLine();
                foreach (var teamMember in App.team2)
                {

                    var depth = App.ClientDive.Depth;
                    var timeMnts = App.ClientDive.TimeMnts;
                    TheDive checkIfCan = new TheDive(teamMember, depth, timeMnts);
                }


            }
            else if (input == "3")
            {
                Console.WriteLine("You chose team 3, press enter to see who from this team can do the dive");
                Console.ReadLine();
                foreach (var teamMember in App.team3)
                {
                    var depth = App.ClientDive.Depth;
                    var timeMnts = App.ClientDive.TimeMnts;
                    TheDive checkIfCan = new TheDive(teamMember, depth, timeMnts);
                }


            }


        }
    }
}
