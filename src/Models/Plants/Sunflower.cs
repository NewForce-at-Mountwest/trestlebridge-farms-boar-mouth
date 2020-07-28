using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompostProducing
    {
        private int _seedsProduced = 650;

        private double compostProduced = 21.6;
        public string Type { get; } = "Sunflower";

        public double Compost()
        {
            return compostProduced;
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}