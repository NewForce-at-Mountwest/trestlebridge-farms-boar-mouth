using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Goat : IResource, IGrazing {

        private Guid _id = Guid.NewGuid();
        
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 4.1;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze () {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        

        public override string ToString () {
            return $"Goat {this._shortId}. Baaaahhhhhh!";
        }

        public double Compost()
        {
            throw new NotImplementedException();
        }
    }
}