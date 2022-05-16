using CoffeeMachine.Main_GUI_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI();

            gui.StartMenu();
        }
    }
}
