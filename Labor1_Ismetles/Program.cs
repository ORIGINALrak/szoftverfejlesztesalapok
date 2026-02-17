using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1_Ismetles
{
    enum SpeciesType { Dog, Panda, Rabbit };
    internal class Program
    {
        static void Main(string[] args)
        {
            Cage[] nicolas = new Cage[4];
            nicolas[0] = new Cage(5);
            nicolas[0].Add(new Animal("Buksi", false, 10, SpeciesType.Dog));
            nicolas[0].Add(new Animal("Nyúl", true, 1, SpeciesType.Rabbit));
            nicolas[0].Add(new Animal("Panda", false, 50, SpeciesType.Panda));
            nicolas[0].Add(new Animal("Dog#2", true, 3, SpeciesType.Dog));
            nicolas[0].Add(new Animal("Dog#3", false, 4, SpeciesType.Dog));
            nicolas[1] = new Cage(2);
            nicolas[0].Add(new Animal("Dog#4", true, 6, SpeciesType.Dog));
            nicolas[0].Add(new Animal("Dog#5", false, 7, SpeciesType.Dog));
            nicolas[2] = new Cage(3);
            nicolas[0].Add(new Animal("Panda#2", true, 30, SpeciesType.Panda));
            nicolas[0].Add(new Animal("Panda", false, 40, SpeciesType.Panda));
            nicolas[3] = new Cage(6);
        }
        static int MelyikKetrec(Cage[] ketrecek, SpeciesType s)
        {
            int maxIDX = 0;
            for (int i = 0; i < ketrecek.Length; i++)
            {
                if (ketrecek[maxIDX].HanyAdottFajuAllat(s) < ketrecek[i].HanyAdottFajuAllat(s))
                {
                    maxIDX = i;
                }
            }
            return maxIDX;
        }
        static Cage[] MakeCagesFromFiles(string dirname)
        {
            if(!Directory.Exists(dirname));
            {
                return null;
            }
            string[] files = Directory.GetFiles(dirname, "*.txt");
            Cage[] cages = new Cage[files.Length];
            for(int i = 0; i < files.Length; i++)
            {
                cages[i] = new Cage(files[i]);
            }
            return cages;
        }
    }
}
