using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<ICluck>
    {
        //Capacity of facility
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();

        //List of chickens in facility
        private List<ICluck> chickens = new List<ICluck>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        //Adding chickens to chicken house
        public void AddResource(ICluck resource)
        {
            chickens.Add(resource);
        }

        public void AddResource(List<ICluck> resources)
        {
            chickens.AddRange(resources);
        }

        //Gets the total count of chickens in each chicken house
        public int GetTotal()
        {
            return chickens.Count;
        }

        //Converting chickens in chicken house to a string that can be printed in the farm report
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this.chickens.Count} chickens\n");
            this.chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}