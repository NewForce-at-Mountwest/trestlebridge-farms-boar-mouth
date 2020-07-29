using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, ICluck chicken)
        {
            Utils.Clear();

            //Prints each chicken house facility available
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if(farm.ChickenHouses[i].GetTotal() < farm.ChickenHouses[i].Capacity){
                Console.WriteLine($"{i + 1}. Chicken House ({farm.ChickenHouses[i].GetTotal()} chickens)");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Where would you like to place the chicken?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //Adds chicken to the particular chicken house selected
            farm.ChickenHouses[choice-1].AddResource(chicken);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<ICluck>(animal, choice);

        }
    }
}