using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingApp
{
    internal class Equipment
    {
        private string type { get; set; }

        public int LitersOfGas { get; set; }

       public int GasTankPressure { get; set; }

        public int TotalAmountofGas { get; set; }   

        public Equipment(string _type, int _gasTankPressure)
        {
            Type = _type;
            LitersOfGas = 0;
            GasTankPressure = _gasTankPressure;
            TotalAmountofGas = 0;
            FillUpInfo();
        }

      

        public string Type
        {
            get { return type; }
            set
            {
                if(value == "single tank" || value == "double tanks")
                {
                    type = value;
                }
                else { type = "invalid"; }
            }
        }


        public void FillUpInfo()
        {
            if(type == "single tank")
            {
                LitersOfGas = 15;
                TotalAmountofGas = LitersOfGas * GasTankPressure;

            }
            if (type == "double tanks")
            {
                LitersOfGas = 2 * 12;
                TotalAmountofGas = LitersOfGas * GasTankPressure;

            }
        }
    }
}
