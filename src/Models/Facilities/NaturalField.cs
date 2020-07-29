using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> plants = new List<ICompostProducing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource(ICompostProducing resource)
        {
            plants.Add(resource);
        }

        public void AddResource(List<ICompostProducing> resources)
        {
            plants.AddRange(resources);
        }

        public int GetTotal()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural Field {shortId} has {this.plants.Count} plants\n");
            this.plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}