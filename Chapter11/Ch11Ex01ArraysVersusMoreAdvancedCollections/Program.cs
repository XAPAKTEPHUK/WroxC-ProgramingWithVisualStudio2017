using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex01ArraysVersusMoreAdvancedCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Create an Array type collection of Animal objects and use it");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");
            foreach (Animal myAnimal in animalArray)
            {
                WriteLine($"New {myAnimal.ToString()} object added to array collection, Name = {myAnimal.Name}");
            }

        }
    }
}
