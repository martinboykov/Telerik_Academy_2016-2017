using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1_Generic_Classes
{
    public class Dog
    {
        // Static variable
        static int dogCount;
        // Instance variables
        private string name;
        private int age;
        public Dog()
        {
            dogCount += 1;
        }
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            dogCount += 1;
        }
        public void Bark()
        {
            Console.Write("wow-wow");
        }
        // Non-static (instance) method
        public void PrintInfo()
        {
            // Accessing instance variables – name and age
            Console.Write("Dog's name: " + this.name + "; age: "
            + this.age + "; often says: ");
            // Calling instance method
            this.Bark();
        }
    }
    public class Cat
    {
        // Static variable
        static int catCount;
        // Instance variables
        private string name;
        private int age;
        public Cat()
        {
            catCount += 1;
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            catCount += 1;
        }
        public void Bark()
        {
            Console.Write("miau-miau");
        }
        // Non-static (instance) method
        public void PrintInfo()
        {
            // Accessing instance variables – name and age
            Console.Write("Cat's name: " + this.name + "; age: "
            + this.age + "; often says: ");
            // Calling instance method
            this.Bark();
        }
    }
    //public class AnimalShelter - нетипизиран клас
    //public class AnimalShelter<TAnimal> - типизиран клас
    public class AnimalShelter<TAnimal>
    {
        //fields
        private const int DefaultPlacesCount = 20;
        private TAnimal[] animalList;
        private int count;

        //constructors
        public AnimalShelter()
        : this(DefaultPlacesCount)
        {
        }

        public AnimalShelter(int placesCount)
        {
            this.animalList = new TAnimal[placesCount];
            this.count = 0;
        }

        //methods
        public void Shelter(TAnimal newAnimal)
        {
            if (this.count >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            this.animalList[this.count] = newAnimal;
            this.count++;
        }
        public TAnimal Release(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            TAnimal releasedAnimal = this.animalList[index];
            for (int i = index; i < this.count - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.count - 1] = default(TAnimal);
            this.count--;
            return releasedAnimal;
        }
    }
    public class AnimalShelterExample
    {
        static void Main()
        {
            AnimalShelter<Dog> dogsShelter = new AnimalShelter<Dog>();
            AnimalShelter<Cat> catsShelter = new AnimalShelter<Cat>();
            catsShelter.Shelter(new Cat());
            catsShelter.Shelter(new Cat());
            catsShelter.Shelter(new Cat());
            Cat catX = catsShelter.Release(1); // Release the second cat
            Console.WriteLine(catX);
            catX = catsShelter.Release(0); // Release the first cat
            dogsShelter.Shelter(new Dog());
            dogsShelter.Shelter(new Dog());
            dogsShelter.Shelter(new Dog());
            Dog dogX = dogsShelter.Release(1); // Release the second dog
            Console.WriteLine(dogX);
            dogX = dogsShelter.Release(0); // Release the first dog
            Console.WriteLine(dogX);
            //d = shelter.Release(0); // Exception: invalid cell index
        }
    }
}
