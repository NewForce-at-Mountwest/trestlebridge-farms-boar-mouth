using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;


namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
             Utils.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
              {
                if(farm.PlowedFields[i].GetTotal() < farm.PlowedFields[i].Capacity){
                 Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].GetTotal()} plants)");
                }
               
            }

             Console.WriteLine();

            
            Console.WriteLine($"Place the seed where?");

             Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.PlowedFields[choice-1].AddResource(plant);
        }
    }
}