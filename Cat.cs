using System;
namespace cois2020assignment1
{
	public class Cat : Animal
	{
		public Breed breed { get; set; } // breed of cat
        public Cat(int AnimalID, string AnimalName, double AnimalAge, Position AnimalPosition, Breed AnimalBreed) // constructor for Animal with ID, Name, Age, Position and Breed values
            : base(AnimalID,AnimalName,AnimalAge,AnimalPosition)
		{
			this.breed = AnimalBreed;
        }
        public override string ToString() // prints all values of cat
        {
            return $" ID: {ID}, Name: {name}, Age: {age}, Position: ({pos.x}, {pos.y}, {pos.z}), Breed: {breed}.";
        }
    }
}
public enum Breed // different values of breed enum
{
    Abyssinian,
    BritishShorthair,
    Bengal,
    Himalayn,
    Ocicat,
    Serval
}

