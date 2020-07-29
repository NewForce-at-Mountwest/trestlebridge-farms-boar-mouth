using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IQuack, IEggProducing, IFeatherProducing {

        private Guid _id = Guid.NewGuid();
        private int eggsProduced = 7;
        private double feathersProduced = 0.5;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        
        public string Type { get; } = "Duck";
        public double FeedPerDay { get; set;} = 0.9;

        // Methods
        public void Feed () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quack!";
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