using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Ingredients
{
    public class Tea
    {
        public int TeaAmount;
        public string TeaStrength;

        public Tea(Water water, Herb herbs)
        {
            TeaAmount = GetWaterAmount(water);
            TeaStrength = GetTeaStrength(herbs);
        }

        private int GetWaterAmount(Water water)
        {
            return water.Mililiter;
        }

        private string GetTeaStrength(Herb herbs)
        {
            double maxAmount = 20;
            Convert.ToDouble(herbs.Gram);
            double percentage = herbs.Gram / maxAmount;
            return percentage.ToString("P");
        }
    }
}
