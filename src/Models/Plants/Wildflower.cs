using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostProducing
    {
        private double compostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public double Compost()
        {
            return compostProduced;
        }

        public override string ToString () {
            return $"Wildflower. Rad!";
        }
    }
}