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
            Animal[] animalArray = new Animal[2]; //simple arrays must be initialized with fixed value
            Cow myCow1 = new Cow("Lea");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");
            foreach (Animal myAnimal in animalArray)
            {
                WriteLine($"New {myAnimal.ToString()} object added to array collection, Name = {myAnimal.Name}");
            }
            WriteLine($"Array collection contains{animalArray.Length} objects."); //Length property is used to output the number of items in an array
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            WriteLine();
            WriteLine("Create an ArrayList type collection of Animal objects and use it");
            ArrayList animalArrayList = new ArrayList(); //collections don't need a size to be initialized
            Cow myCow2 = new Cow("Donna");
            animalArrayList.Add(myCow2); //add() method is used to to add new items
            animalArrayList.Add(new Chicken("Andrea"));
            foreach (Animal myAnimal in animalArrayList)
            {
                WriteLine($"New {myAnimal.ToString()} object added to ArrayList collection, Name = {myAnimal.Name}");
            }
            WriteLine($"ArrayList collection contains {animalArrayList.Count} objects.");//Count property is used to output the numbers of items in a collection
            ((Animal)animalArrayList[0]).Feed(); //casting is used to call methodes supllied by derieved class
            ((Chicken)animalArrayList[1]).LayEgg();
            WriteLine();
            WriteLine("Additional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);//removing item with the index 0 results in all other items being shiftedone place in the array
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEgg();
            WriteLine($"The animal called {myCow1.Name} is at index {animalArrayList.IndexOf(myCow1)}");
            myCow1.Name = "Mary";
            WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name }.");
            ReadKey();
        }
    }
}
