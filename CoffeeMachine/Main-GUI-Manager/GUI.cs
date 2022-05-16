using CoffeeMachine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Main_GUI_Manager
{
    // This class creates a menu for the user to navigate through
    public class GUI
    {
        Manager mana = new Manager();
        bool spacebarTerminator = false;

        public void StartMenu()
        {
            // Bool to control the menu
            bool startMenu = true;

            while (startMenu)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("               Hot Beverage Machine");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("1. Brew Coffee");
                Console.WriteLine("2. Brew Tea");
                Console.WriteLine("1. Brew Espresso");
                Console.WriteLine("4. Exit");
                Console.Write("\r\nPress a number.");


                // Switch case for each menu point
                switch (Console.ReadKey(true).KeyChar)
                {
                    // Creates a journal
                    case '1':
                        BrewCoffeeMenu();
                        break;
                    case '2':
                        BrewTeaMenu();
                        break;
                    case '3':
                        BrewEspressoMenu();
                        break;
                    // Exits the program
                    case '4':
                        ExitApplication();
                        break;
                    default:
                        break;
                }
            }
        }

        private void BrewCoffeeMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               Coffee Machine");
            Console.WriteLine("==================================================\n");

            Console.Write("Enter water amount (Between 200ml to 2000ml): ");
            int waterAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter bean amount (Between 1g to 50g): ");
            int beanAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter amount of degrees (Between 80 degrees to 100 degrees): ");
            int degrees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCoffee is now being brewed.");
            string[] coffeeDetails = mana.BrewCoffee(waterAmount, beanAmount, degrees);

            Console.WriteLine($"\n{coffeeDetails[0]}ml of coffee was produced, with a strength of {coffeeDetails[1]}");

            Console.WriteLine("\nPress spacebar to return to main menu.");

            while (spacebarTerminator == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    spacebarTerminator = true;
                }
            }
        }

        private void BrewTeaMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               Tea Machine");
            Console.WriteLine("==================================================\n");

            Console.Write("Enter water amount (Between 200ml to 2000ml): ");
            int waterAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter herb amount (Between 1g to 20g): ");
            int herbAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter amount of degrees (Between 80 degrees to 100 degrees): ");
            int degrees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTea is now being brewed.");
            string[] teaDetails = mana.BrewTea(waterAmount, herbAmount, degrees);

            Console.WriteLine($"\n{teaDetails[0]}ml of tea was produced, with a strength of {teaDetails[1]}");

            Console.WriteLine("\nPress spacebar to return to main menu.");

            while (spacebarTerminator == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    spacebarTerminator = true;
                }
            }
        }

        private void BrewEspressoMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               Espresso Machine");
            Console.WriteLine("==================================================\n");

            Console.Write("\nEnter bean amount (Between 1g to 10g): ");
            int beanAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter amount of degrees (Between 80 degrees to 100 degrees): ");
            int degrees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEspresso is now being brewed.");
            string espressoStrength = mana.BrewEspresso(beanAmount, degrees);

            Console.WriteLine($"\n200ml of espresso was produced, with a strength of {espressoStrength}");

            Console.WriteLine("\nPress spacebar to return to main menu.");

            while (spacebarTerminator == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    spacebarTerminator = true;
                }
            }
        }

        private void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
