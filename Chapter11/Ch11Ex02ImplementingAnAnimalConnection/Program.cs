using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex02ImplementingAnAnimalConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Marry"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            ReadKey();
        }
    }
}
