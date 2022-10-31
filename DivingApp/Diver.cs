using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class Diver
    {
        public string DiverName { get; set; }
        private string level { get; set; }
        public int DepthAllowedtoGo { get; set; }

        public int GasConsomptionPerMinuteSurface { get; set; }

        public bool AllowedToUseNitrox { get; set; }

        public int NitroxLevel { get; set; }

        public Equipment equipment { get; set; }

        public Gass gassChoice { get; set; }

        public Diver(string _diverName, string _level, Equipment _equipment, Gass _gassChoice)
        {
            DiverName = _diverName;
            Level = _level;
            DepthAllowedtoGo = 0;
            GasConsomptionPerMinuteSurface = 0;
            AllowedToUseNitrox = false;
            equipment = _equipment;
            NitroxLevel = 0;
            gassChoice = _gassChoice;

            AllowedDepthandAirConsomption();
        }

        public Diver(string _diverName, string _level )
        {
            DiverName = _diverName;
            Level = _level;
            DepthAllowedtoGo = 0;
            GasConsomptionPerMinuteSurface = 0;
            AllowedToUseNitrox = false;
            
            NitroxLevel = 0;
           

            AllowedDepthandAirConsomption();
        }


        public string Level
        {
            get { return level; }
            set
            {
                if(value== "Open Water" || value == "Advance" || value == "DiveMaster")
                {
                    level = value;
                }

                else
                {
                    level = "Invalid level";
                }
            }
        }

        public void HasNitroxCourse()
        {
            AllowedToUseNitrox = true;
        }

        public void AllowedDepthandAirConsomption()
        {
            if(Level == "Open Water")
            {
                DepthAllowedtoGo = 18;
                GasConsomptionPerMinuteSurface = 35;
            }

            if (Level == "Advance")
            {
                DepthAllowedtoGo = 30;
                GasConsomptionPerMinuteSurface = 25;
            }

            if (Level == "DiveMaster")
            {
                DepthAllowedtoGo = 40;
                GasConsomptionPerMinuteSurface = 20;
            }
        }

        public Equipment ChooseEquipment()
        {
            Console.WriteLine("Time to choose your equipment");
            Console.WriteLine("We offer:");
            Console.WriteLine("1 - Single Tank");
            Console.WriteLine("2 - Double Tank");
            var Inputtanks = Console.ReadLine();
            var tank = ValidateInput.validateInputTank(Inputtanks);
            Console.WriteLine("We offer:");
            Console.WriteLine("1 - 200 Bars");
            Console.WriteLine("2 - 300 Bars");
            var InputPressure = Console.ReadLine();
            var pressure = Convert.ToInt32(ValidateInput.validateInputPressure(InputPressure));
            Equipment e = new Equipment(tank,pressure);
            return e;
        }

       
        



        public void AskAboutNtCourse()
        {
            Console.WriteLine("Time to choose wich gas do you want use");
            Console.WriteLine("Are you NITROX certified? Type yes or no to answer");
            var answer = Console.ReadLine();
            if (answer == "yes")
            {
                HasNitroxCourse();
            }
        }
        public void ChooseGas()
        {
            AskAboutNtCourse();


            if (AllowedToUseNitrox == false)
            {
                Console.WriteLine("Since you dont have Nitrox course, your only option is to use Air");
                gassChoice = new Air();
            }

            else
            {
                Console.WriteLine("You have 3 options");
                Console.WriteLine("1 -Air");
                var giveAirInfo = new Air();
                giveAirInfo.Information();

                Console.WriteLine("2 - Nitrox 32");
                var giveN32Info = new Nitrox(22);
                giveN32Info.UseStandard32();
                giveN32Info.Information();

                Console.WriteLine("3 - Nitrox 36");
                var giveN36Info = new Nitrox(22);
                giveN36Info.UseStandard36();
                giveN36Info.Information();

                var inputGas = Console.ReadLine();
                if(inputGas == "1")
                {
                    gassChoice = new Air();
                }
                else if (inputGas == "2")
                {
                    Nitrox nitrox = new Nitrox(22);
                    nitrox.UseStandard32();
                    gassChoice = nitrox;
                   
                    
                }
                else if (inputGas == "3")
                {
                    Nitrox nitrox = new Nitrox(22);
                    nitrox.UseStandard36();
                    gassChoice = nitrox;

                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            }
      

            
       
        
        }



        


    }
}
