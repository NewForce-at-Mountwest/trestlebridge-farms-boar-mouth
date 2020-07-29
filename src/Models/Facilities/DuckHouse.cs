using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<IQuack>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IQuack> ducks = new List<IQuack>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        //Adding ducks to duck house
        public void AddResource (IQuack resource)
        {
            ducks.Add(resource);
        }

        public void AddResource (List<IQuack> resources) 
        {
            ducks.AddRange(resources);
        }

        //Gets the total count of ducks in each duck house
        public int GetTotalDucks()
        {
            return ducks.Count;
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this.ducks.Count} ducks\n");
            this.ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}