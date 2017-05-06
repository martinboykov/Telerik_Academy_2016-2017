using System;

class DogMeeting
{
	static void Main()
	{
		Console.Write("Enter first dog's name: ");
        string dogName = Console.ReadLine();
        Console.Write("Enter first dog's breed: ");
        string dogBreed = Console.ReadLine();

        // Use the Dog constructor to assign name and breed

        //short version /shortcut/
        Dog firstDog = new Dog(dogName, dogBreed); 

        //long version
        //Dog firstDog = new Dog()
        //{
        //    Name = dogName,
        //    Breed = dogBreed
        //};



        // Create a new dog using the parameterless constructor
        Dog secondDog = new Dog();

        // Use properties to set name and breed
        Console.Write("Enter second dog's name: ");
        secondDog.DogName = Console.ReadLine(); 
        Console.Write("Enter second dog's breed: ");
        secondDog.DogName = Console.ReadLine(); 

		// Create a Dog with no name and breed
		Dog thirdDog = new Dog();
        //or
        //Dog fourth = Dog.CreateDog(); //DateTime.Now

		// Save the dogs in an array
		Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

		// Ask each of the dogs to bark
		foreach(Dog dog in dogs)
		{ 
			dog.SayBau(); 
		}
	}
}