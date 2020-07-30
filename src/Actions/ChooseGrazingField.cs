using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();
//Loops over the grazing fields and prints grazing fields if they have the capacity to store more animals
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
               if(farm.GrazingFields[i].GetTotal() < farm.GrazingFields[i].Capacity){
                    Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].GetTotal()} animals)");
                    
               }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Where would you like to place the animal?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[choice-1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}