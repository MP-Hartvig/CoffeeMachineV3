using CoffeeMachine.Ingredients;
using CoffeeMachine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Main_GUI_Manager
{
    internal class Manager
    {
        Machine machine = new Machine();
        Espresso espresso;
        Coffee coffee;
        Tea tea;

        public string[] BrewCoffee(int waterAmount, int beanAmount, int degrees)
        {
            Water water = new Water(waterAmount);
            Bean beans = new Bean(beanAmount);

            machine.FillContainer();
            machine.AddFilter();
            machine.TurnOn();
            machine.SetDegrees(degrees);
            machine.GrindBeans();
            coffee = machine.BrewCoffee(water, beans);
            machine.TurnOff();
            machine.RemoveFilter();

            string[] coffeeDetails = new string[2];
            coffeeDetails[0] = coffee.CoffeeAmount.ToString();
            coffeeDetails[1] = coffee.CoffeeStrength.ToString();

            return coffeeDetails;
        }

        public string[] BrewTea(int waterAmount, int herbAmount, int degrees)
        {
            Water water = new Water(waterAmount);
            Herb herb = new Herb(herbAmount);

            machine.FillContainer();
            machine.AddFilter();
            machine.TurnOn();
            machine.SetDegrees(degrees);
            tea = machine.BrewTea(water, herb);
            machine.TurnOff();
            machine.RemoveFilter();

            string[] TeaDetails = new string[2];
            TeaDetails[0] = tea.TeaAmount.ToString();
            TeaDetails[1] = tea.TeaStrength.ToString();

            return TeaDetails;
        }

        public string BrewEspresso(int beanAmount, int degrees)
        {
            Bean beans = new Bean(beanAmount);

            machine.FillContainer();
            machine.AddFilter();
            machine.TurnOn();
            machine.SetDegrees(degrees);
            machine.GrindBeans();
            espresso = machine.BrewEspresso(beans);
            machine.TurnOff();
            machine.RemoveFilter();

            return espresso.EspressoStrength;
        }
    }
}
