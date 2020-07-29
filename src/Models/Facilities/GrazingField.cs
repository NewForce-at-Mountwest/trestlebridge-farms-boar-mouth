using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;

        //TODO:: make a conditional preventing a user from adding an animal if the grazing field is already at capacity

        // public void AddToFacility(IGrazing animalToAdd){
        //     if (_animals.Count <= _capacity)
        //     {
        //         _animals.Add(animalToAdd);
        //     }else{
        //         Console.WriteLine("This facility is full :*(");
        //     }

        // }
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }
//attempting to enforce a capacity limit for grazing fields
        public void AddResource (IGrazing animal)
        {
            // TODO: implement this...
            // if(_animals.Count <= Capacity){
            _animals.Add(animal);
            // }else{
            //     Console.WriteLine("This is too full :*(");
            // }
        }

        public void AddResource (List<IGrazing> animals) 
        {
            // TODO: implement this...
           
            throw new NotImplementedException();
        }

        // Gets the total count of animals in each grazing field
        public int GetTotal()
        {
            return _animals.Count;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}