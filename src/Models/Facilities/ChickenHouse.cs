using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<ICluck>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<ICluck> chickens = new List<ICluck>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource(ICluck resource)
        {
            chickens.Add(resource);
        }

        public void AddResource(List<ICluck> resources)
        {
            throw new NotImplementedException();
        }

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