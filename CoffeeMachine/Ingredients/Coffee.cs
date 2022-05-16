using CoffeeMachine.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Liquids
{
    public class Coffee
    {
        public int CoffeeAmount;
        public string CoffeeStrength;

        public Coffee(Water water, Bean bean)
        {
            CoffeeAmount = GetWaterAmount(water);
            CoffeeStrength = GetCoffeeStrength(bean);
        }

        private int GetWaterAmount(Water water)
        {
            return water.Mililiter;
        }

        private string GetCoffeeStrength(Bean bean) 
        {
            double maxAmount = 50;
            Convert.ToDouble(bean.Gram);
            double percentage = bean.Gram / maxAmount;
            return percentage.ToString("P");
        }
    }
}
