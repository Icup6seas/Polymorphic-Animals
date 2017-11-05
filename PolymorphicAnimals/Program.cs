using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicAnimals
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AnimalObjects> myAnimalObjects = InitailizeAnimalObjects();
            Console.WriteLine("List of Animal Objects");
            foreach (AnimalObjects animalObject in myAnimalObjects)
            {
                Console.WriteLine($"{animalObject.AnimalObjectID} {animalObject.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("List of Birds");
            foreach (AnimalObjects animalObject in myAnimalObjects)
            {
                if (animalObject is Birds)
                {
                    Birds bird = animalObject as Birds;
                    Console.WriteLine($"{bird.AnimalObjectID} {bird.Name} {bird.CanFly}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("List of Fish");
            foreach (AnimalObjects animalObject in myAnimalObjects)
            {
                if (animalObject is Fish)
                {
                    Fish fish = animalObject as Fish;
                    Console.WriteLine($"{fish.AnimalObjectID} {fish.Name} {fish.PrimarySea}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("List of Land Mammals");
            foreach (AnimalObjects animalObject in myAnimalObjects)
            {
                if (animalObject is LandMammal)
                {
                    LandMammal landMammal = animalObject as LandMammal;
                    Console.WriteLine($"\n{landMammal.AnimalObjectID} \n{landMammal.Name} \n{landMammal.Color} \n{landMammal.NumberOfLegs}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }



        static List<AnimalObjects> InitailizeAnimalObjects()
        {
            List<AnimalObjects> myAnimalObjects = new List<AnimalObjects>()
        {
            new Birds()
            {
                AnimalObjectID = 1,
                Name = "Crow"
            },

            new Birds()
            {
                AnimalObjectID = 2,
                Name = "Blue Jay"
            },

            new Birds()
            {
                AnimalObjectID = 3,
                Name = "Cardinal"
            },

            new Fish()
            {
                AnimalObjectID = 4,
                Name = "Large Mouth Bass"
            },

            new Fish()
            {
                AnimalObjectID = 5,
                Name = "Sturgeon"
            },

            new Fish()
            {
                AnimalObjectID = 6,
                Name = "Tuna"
            },

            new LandMammal()
            {
                AnimalObjectID = 7,
                Name = "Elephant",
                Color = "Color: Gray",
                NumberOfLegs = "Number of Legs: 4"
            },

            new LandMammal()
            {
                AnimalObjectID = 8,
                Name = "Horse",
                Color = "Color: Black",
                NumberOfLegs = "Number of Legs: 4"
            },

            new LandMammal()
            {
                AnimalObjectID = 9,
                Name = "Human",
                Color = "Color: Varies",
                NumberOfLegs = "Number of Legs: 2"
            },
        };

            AnimalObjects CanFly = new AnimalObjects() as Birds;

            return myAnimalObjects;
        }
    }
}
