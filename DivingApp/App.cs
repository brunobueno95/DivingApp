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
         public static List<Diver> team1 = new List<Diver>();
        public static List<Diver> team2 = new List<Diver>();
        public static  List<Diver> team3 = new List<Diver>();


        public App()
        {
            RunApp();
        }

        public void RunApp()
        {
            FillUpTeams();

            Greeting();
            CollectInfo();
            Console.WriteLine("Now that we have all your Info You can choose the dive you want to do");
            TheDive.ChoosingDive();
            //TheDive.cantDoTheDive();
            ValidateInput.validateInputTeam(ChooseATeam());


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

        public string ChooseATeam()
        {
            Console.WriteLine("Now that we have all your Info You can choose a Team to join");
            Console.WriteLine("Its Always Funnier to dive in teams, meet new people and share the adventure");
            Console.WriteLine("The down side of joining a team, is that not everyone is on the same level," +
                "so you have to check previously if everyone can do the dive");
            Console.WriteLine("First choose the team u want to join, than choose the dive you wish, and we will check" +
                "who from your team can do the dive");
            Console.WriteLine("Choose a team");
            Console.WriteLine("1 - team 1");
            Console.WriteLine("2 - team 2");
            Console.WriteLine("3 - team 3");
            var input = Console.ReadLine();
            return input;
        }

        

        public void FillUpTeams()
        {

            team1.Add(new Diver("James", "Open Water", new Equipment("single tank", 200), new Air()));
            team1.Add(new Diver("Miles", "DiveMaster", new Equipment("double tanks", 200), new Nitrox(36)));
            team1.Add(new Diver("Gabriel", "Advance", new Equipment("single tank", 300), new Air()));
            team1.Add(new Diver("Bruno", "DiveMaster", new Equipment("single tank", 200), new Nitrox(32)));

            team2.Add(new Diver("Adam", "Open Water", new Equipment("single tank", 200), new Air()));
            team2.Add(new Diver("Sandra", "DiveMaster", new Equipment("double tanks", 200), new Nitrox(36)));
            team2.Add(new Diver("Juan", "Advance", new Equipment("single tank", 300), new Air()));
            team2.Add(new Diver("Vanessa", "DiveMaster", new Equipment("single tank", 200), new Nitrox(32)));

            team3.Add(new Diver("Peter", "Open Water", new Equipment("single tank", 200), new Air()));
            team3.Add(new Diver("Kai", "DiveMaster", new Equipment("double tanks", 200), new Nitrox(36)));
            team3.Add(new Diver("Tonja", "Advance", new Equipment("single tank", 300), new Air()));
            team3.Add(new Diver("Kelly", "DiveMaster", new Equipment("single tank", 200), new Nitrox(32)));



        }


        
    }
}
