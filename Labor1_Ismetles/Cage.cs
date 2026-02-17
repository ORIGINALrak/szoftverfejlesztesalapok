using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1_Ismetles
{
    internal class Cage
    {
        Animal[] animals;
        int numberOfAnimals;

        public Cage(int N)
        {
            animals = new Animal[N];
            numberOfAnimals = 0;
        }

        public bool Add(Animal animal)
        {
            if( numberOfAnimals == animals.Length)
            {
                return false;
            }
            animals[numberOfAnimals]= animal;
            numberOfAnimals++;
            return true;
        }
        public void Delete(string name)
        {
            int i = 0;
            while (i < animals.Length && animals[i].Name != name)
            {
                i++;
            }
            if(i == animals.Length)
            {
                return;
            }
            animals[i] = animals[numberOfAnimals-1];
            animals[numberOfAnimals-1] = null;
        }

        public int HanyAdottFajuAllat(SpeciesType s)
        {
            int db = 0;
            foreach (Animal anim in animals)
            {
                if(anim.Species == s)
                {
                    db++;
                }
            }
            return db;
        }
        public bool VaneAdottFajuEsNemuAllat(SpeciesType s, bool g)
        {
            foreach (Animal anim in animals)
            {
                if (anim.Species == s && anim.Gender == g)
                {
                    return true;
                }
            }
            return false;
        }
        public Animal[] MelyekAEzenFajuak(SpeciesType s)
        {
            Animal[] temp = new Animal[animals.Length];
            int ind = 0;
            foreach (Animal animal in animals)
            {
                if (animal.Species == s)
                {
                    temp[ind] = animal;
                    ind++;
                }
            }
            Animal[] eredmeny = new Animal[ind];
            for (int i = 0; i < ind; i++)
            {
                eredmeny[i] = temp[i];
            }
            return temp;
        }
        public double AtlagosTomeg(SpeciesType s)
        {
            int db = 0;
            int osszeg = 0;
            foreach (Animal anim in animals)
            {
                if (anim.Species == s)
                {
                    osszeg+= anim.Weight;
                    db++;
                }
            }
            return osszeg / (double)db;
        }
        public bool VaneAzonosFaju()
        {
            int[] himekSzama = new int[3];
            int[] nostenyekSzama = new int[3];
            foreach (Animal anim in animals)
            {
                if(anim.Gender == false)
                {
                    if (himekSzama[(int)anim.Species]>0)
                    {
                        return true;
                    }
                    else
                    {
                        nostenyekSzama[(int)anim.Species]++;
                    }
                }
                else
                {
                    if (nostenyekSzama[(int)anim.Species] > 0)
                    {
                        return true;
                    }
                    else
                    {
                        himekSzama[(int)anim.Species]++;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            
            string s = "A ketrec lakói:\n";
            for (int i = 0; i < numberOfAnimals; i++)
            {
                s += " - " + animals[i].ToString() + "\n";
            }
            return s;
        }

        public Cage(string filename)
        {
            string[] adatok = File.ReadAllLines(filename);
            animals = new Animal[adatok.Length];
            numberOfAnimals = adatok.Length;
            for (int i = 0;i < animals.Length; i++)
            {
                string[] darabok = adatok[i].Split(',');
                string name = darabok[0];
                bool gender = bool.Parse(darabok[1]);
                int weight = int.Parse(darabok[2]);
                SpeciesType species = (SpeciesType)Enum.Parse(typeof(SpeciesType), darabok[3]);

                animals[i] = new Animal(name, gender, weight, species);
            }
        }
    }
}
