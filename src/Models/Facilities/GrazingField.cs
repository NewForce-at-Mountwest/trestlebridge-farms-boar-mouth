using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

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

//functions to get the specific animal count => GroupBy would be better if I could figure it out
        public int CowCount(){
            int count = 0;
            count = _animals.Where(animal => animal.Type == "Cow").Count();
            return count;
        }

        public int OstrichCount(){
            int count = 0;
            count = _animals.Where(animal => animal.Type == "Ostrich").Count();
            return count;
        }

        public int GoatCount(){
            int count = 0;
            count = _animals.Where(animal => animal.Type == "Goat").Count();
            return count;
        }

         public int SheepCount(){
            int count = 0;
            count = _animals.Where(animal => animal.Type == "Sheep").Count();
            return count;
        }

        public int PigCount(){
            int count = 0;
            count = _animals.Where(animal => animal.Type == "Pig").Count();
            return count;
        }

        //TODO:: GROUP BY TO PAIR COWS WITH ANIMALS IN GRAZING FIELD. 
        //TODO:: FIGURE OUT WHAT TO DO ABOUT GETTING A NEW LIST OF ANIMALS, AS THIS ONE IS PRIVATE.
        //TODO:: GROUP ANIMALS BY TYPE SINCE ALL HAVE A TYPE
        
        //TODO:: LOOP OVER THE PAIRS TO GET COUNT IN CHOOSEGRAZINGFIELD.CS

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

public List<GrazingField> Cows {get; } = new List<GrazingField>();
//         public int GetTotalCows(){
//             return Cows.Count;
//         }

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