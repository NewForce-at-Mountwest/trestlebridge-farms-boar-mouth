using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource((ICluck)resource);
                    break;
                case "Sunflower":
                    NaturalFields[index].AddResource((ICompostProducing)resource);
                    break;
                case "Wildflower":
                    NaturalFields[index].AddResource((ICompostProducing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field); 
            
        }

          public void AddDuckHouse (DuckHouse field)
        {
            DuckHouses.Add(field); 
            
        }

        public void AddChickenHouse (ChickenHouse house)
        {
            ChickenHouses.Add(house);
        }

        public void AddNaturalField (NaturalField field)
        {
           NaturalFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
//Prints report of duckhouses for user when user presses 4 in the main menu
            DuckHouses.ForEach(dh => report.Append(dh));

            ChickenHouses.ForEach(ch => report.Append(ch));

            NaturalFields.ForEach(nf => report.Append(nf));

            return report.ToString();
        }
    }
}