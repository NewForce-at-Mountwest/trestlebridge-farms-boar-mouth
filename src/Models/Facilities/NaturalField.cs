using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> _plants = new List<ICompostProducing>();
        private IEnumerable<object> plants;

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource(ICompostProducing resource)
        {
            _plants.Add(resource);
        }

        public void AddResource(List<ICompostProducing> resources)
        {
            _plants.AddRange(resources);
        }

        public int GetTotal()
        {
            return _plants.Count;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural Field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
         public int SunflowerCount(){
            int count = 0;
            count = _plants.Where(plant => plant.Type == "Sunflower").Count();
            return count;
        }
        public int WildflowerCount(){
            int count = 0;
            count = _plants.Where(plant => plant.Type == "Wildflower").Count();
            return count;
    }
}
}