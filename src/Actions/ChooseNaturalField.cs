using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        public static void CollectInput(Farm farm, ICompostProducing plant)
        {
            Utils.Clear();

            //Prints each available natural field 
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field ({farm.NaturalFields[i].GetTotal()} plants)");
            }

            Console.WriteLine();

            Console.WriteLine($"Where would you like to place the seed?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //Adds the plant/seed to the selected natural field
            farm.NaturalFields[choice].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<ICompostProducing>(plant, choice);

        }
    }
}