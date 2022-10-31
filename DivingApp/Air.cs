using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class Air :Gass
    {
      

        public Air()
        {
            TypeOfGas = "Air";
            OxigenPercentage = 21;
            NitrogenPercentage = 79;


        }
    }
}
