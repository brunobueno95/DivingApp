using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal abstract class Gass
    {
      public  string TypeOfGas { get; set; }
      public  int NitrogenPercentage { get; set; }
      
     public  double OxigenPercentage { get; set; }

        

        public void Information()
        {
            Console.WriteLine($"This gas is {TypeOfGas} and it has {NitrogenPercentage} percentage of Nitrogen and" +
                $" {OxigenPercentage} percentage of Oxigen\n");
        }
    }
}
