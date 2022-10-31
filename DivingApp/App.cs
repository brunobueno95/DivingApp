using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class App
    {

            public static Diver Client { get; set; }
            public static TheDive ClientDive { get; set; }
        


        public App()
        {
            RunApp();
        }

        public void RunApp()
        {
            Teams.FillUpTeams();

            Greeting();
            CollectInfo();
            Console.WriteLine("Now that we have all your Info You can choose the dive you want to do");
            var clientD = TheDive.ChoosingDive();
            TheDive.cantDoTheDive(clientD);
            ValidateInput.validateInputTeam(Teams.ChooseATeam(), clientD);


        }

        public void Greeting()
        {
            Console.WriteLine("Hi there, welcome to ScubaExploreres our DiveShop! We are glad to have you here.");
            Console.WriteLine("First we are gonna need to collect some information from you.");
        }

        public void CollectInfo()
        {
            Console.WriteLine("Whats your name?");
            var DName = Console.ReadLine();
            Console.WriteLine($"{DName} whats your Certification level? Choose one of the below.");
            Console.WriteLine("1 - OpenWater");
            Console.WriteLine("2 - Advance");
            Console.WriteLine("3 - DiveMaster");
            var input = Console.ReadLine();
            var level = ValidateInput.validateInputLevel(input);
            
            Client = new Diver(DName, level);
            
            Console.Clear();
            Client.equipment = Client.ChooseEquipment();
            Console.Clear();
            Client.ChooseGas();
            
        }

        


        
    }
}
