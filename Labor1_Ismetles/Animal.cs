using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1_Ismetles
{
    internal class Animal
    {
        string name;
        bool gender;
        int weight;
        SpeciesType species;
        public string Name { get => name; set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Weight { get => weight; set => weight = value; }
        internal SpeciesType Species { get => species; set => species = value; }

        public Animal(string name, bool gender, int weight, SpeciesType species)
        {
            this.Name = name;
            this.Gender = gender;
            this.Weight = weight;
            this.Species = species;
        }

   
    }
}
