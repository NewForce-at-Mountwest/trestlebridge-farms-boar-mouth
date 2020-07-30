using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IQuack duck)
        {
            Utils.Clear();

            //Prints each duck house facility available
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if(farm.DuckHouses[i].GetTotal() < farm.DuckHouses[i].Capacity){
                Console.WriteLine($"{i + 1}. Duck House ({farm.DuckHouses[i].GetTotal()} ducks)");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Where would you like to place the duck?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //Adds duck to the particular duck house selected
            farm.DuckHouses[choice - 1].AddResource(duck);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<ICluck>(animal, choice);

        }
    }
}