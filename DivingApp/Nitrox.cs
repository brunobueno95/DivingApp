using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class Nitrox : Gass
    {
        public Nitrox(int _oxigenPercentage)
        {
            TypeOfGas = "Nitrox";
            OxigenPercentage = _oxigenPercentage;
            NitrogenPercentage = 0;
        }

        public void UseStandard32()
        {
            OxigenPercentage = 32;
            NitrogenPercentage = 100 - 32;
        }

        public void UseStandard36()
        {
            OxigenPercentage = 36;
            NitrogenPercentage = 100 - 36;
        }
    }
}
