using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Chicken : IResource, ICluck, IMeatProducing, IEggProducing, IFeatherProducing {

        private Guid _id = Guid.NewGuid();
        private double meatProduced = 1.7;
        private int eggsProduced = 7;
        private double feathersProduced = 0.5;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        
        public string Type { get; } = "Chicken";
        public double FeedPerDay { get; set;} = 0.9;

        // Methods
        public void Feed () {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double Butcher () {
            return meatProduced;
        }

        public override string ToString () {
            return $"Chicken {this._shortId}. Cluck!";
        }

        public int CollectEggs()
        {
            return eggsProduced;
        }

        public double GatherFeathers()
        {
            return feathersProduced;
        }
    }
}