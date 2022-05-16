using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Ingredients
{
    public class Espresso
    {
        public string EspressoStrength;

        public Espresso(Bean bean)
        {
            EspressoStrength = SetEspressoStrength(bean);
        }

        private string SetEspressoStrength(Bean bean)
        {
            double maxAmount = 10;
            Convert.ToDouble(bean.Gram);
            double percentage = bean.Gram / maxAmount;
            return percentage.ToString("P");
        }
    }
}
