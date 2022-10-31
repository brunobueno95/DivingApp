using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class TheDive
    {
        public Diver WhosDiving { get; set; }
        public int Depth { get; set; }

        public double Pressure { get; set; }

        public int TimeMnts { get; set; }

        public bool CanDoThisDive   { get; set; }

        public TheDive(Diver whosDiving, int _depth, int _time)
        {
            WhosDiving = whosDiving;
            Depth = _depth;
            Pressure = 0;
            CanDoThisDive = true;
            TimeMnts = _time;
            CalculatePressure();
            CheckifDiveCanBeDone();
        }

       

        public void CalculatePressure()
        {
           Pressure = Depth * 0.1 + 1;
        }

        public double CalculatePP02()
        {
            var PP02 = Pressure * (WhosDiving.gassChoice.OxigenPercentage / 100);
            return PP02;
        }

        public void CheckifDiveCanBeDone()
        {
            if(Depth > WhosDiving.DepthAllowedtoGo)
            {
                Console.WriteLine($" {WhosDiving.DiverName} is not certified fot this depth\n");
                CanDoThisDive = false;
            }
            else if(CalculateAirConsomption() > WhosDiving.equipment.TotalAmountofGas)
            {
                Console.WriteLine($" {WhosDiving.DiverName} cant do this dive because it exceeds the amount of air contained on the {WhosDiving.equipment.Type} \n");
                CanDoThisDive = false;
            }
            
            else if (CalculatePP02() > 1.4)
            {
                Console.WriteLine($" {WhosDiving.DiverName} cant do this dive because it exceeds the maximum safe PP02 of 1.4");
                Console.WriteLine($"this dive has {Pressure} atm of pressure and {WhosDiving.DiverName} will achieve {CalculatePP02()} of PP02\n");

                CanDoThisDive = false;
            }
            else
            {
                Console.WriteLine($"{WhosDiving.DiverName} Can do this Dive\n");

                CanDoThisDive = true;
            }
        }

        public double CalculateAirConsomption()
        {
            var totalConsomption = WhosDiving.GasConsomptionPerMinuteSurface * Pressure * TimeMnts;
            return totalConsomption;
        }

        public static TheDive ChoosingDive()
        {
            

            Console.WriteLine("Write down the depth u want to dive, remember we are currently only " +
                "doing recreational dives, so max depth 40m");
            var depth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now choose the time in mnts of how long the dive will be.");
            var timeMnts = Convert.ToInt32(Console.ReadLine());
            TheDive ClientDive = new TheDive(App.Client, depth, timeMnts);
            return ClientDive;

        }

        public static  void cantDoTheDive(TheDive obj)
        {
            if (obj.CanDoThisDive == false)
            {
                Console.WriteLine("You need to choose a different dive");
                ChoosingDive();
            }
            else
            {
                Console.WriteLine("");
            }
        }

        //public double CalculateNitrogen()
        //{
        // without a table or computer havent yet figured out whats the mathematic algoritm
        //}
    }
}
