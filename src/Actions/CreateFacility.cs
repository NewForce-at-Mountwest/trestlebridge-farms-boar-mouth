using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");

            Console.WriteLine("4. Duck House");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();


            switch (Int32.Parse(input))
            {
                case 1:
                //THE CONSOLE.WRITELINE AND READLINE SEND THE USER A CONFIRMATION MESSAGE AFTER CREATING A FACILITY, AND LETS THE USER KNOW HOW TO GET BACK TO THE MAIN MENU
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("Thank you for adding a Grazing Field");
                    Console.WriteLine("Press Enter to return to the Main Menu");
                    Console.WriteLine(">_");
                    Console.ReadLine();
                    break;
                case 2:
                farm.AddPlowedField(new PlowedField());
                Console.WriteLine("You have created a new plowed field! Please press enter to return to the main menu.");
                Console.ReadLine();
                break;
                case 4:
                farm.AddDuckHouse(new DuckHouse());
                Console.WriteLine("Thank you for adding a Duck House!");
                Console.WriteLine("Press Enter to return to the Main Menu");
                Console.WriteLine(">_");
                Console.ReadLine();
                break;
                default:
                    break;
            }
        }
    }
}