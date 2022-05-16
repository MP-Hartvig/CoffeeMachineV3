using CoffeeMachine.Ingredients;
using CoffeeMachine.Interfaces;
using CoffeeMachine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Machine : IHeater, IContainer, ISwitch, IFilter, IGrinder
    {
        public bool FilterInserted { get; private set; }        
        public int Degrees { get; private set; }
        public bool OnOff { get; private set; }

        public Machine() { }

        public void FillContainer() { }

        public void AddFilter() 
        {
            FilterInserted = true;
        }

        public void TurnOn() 
        {
            OnOff = true;
        }

        public void SetDegrees(int degrees)
        {
            Degrees = degrees;
        }

        public void GrindBeans() { }

        public Coffee BrewCoffee(Water water, Bean beans) 
        {
            Coffee coffee = new Coffee(water, beans);
            return coffee;
        }

        public Tea BrewTea(Water water, Herb herbs)
        {
            Tea tea = new Tea(water, herbs);
            return tea;
        }

        public Espresso BrewEspresso(Bean beans)
        {
            Espresso espresso = new Espresso(beans);
            return espresso;
        }

        public void TurnOff() 
        { 
            OnOff = false;
        }

        public void RemoveFilter() 
        {
            FilterInserted = false;
        }
    }
}
