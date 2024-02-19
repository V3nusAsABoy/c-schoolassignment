using System;
namespace cois2020assignment1
{
	public class Snake : Animal
	{
		public double length { get; set; } // length of snake in metres
		public bool venomous { get; set; } // if snake is venemous r not
		public Snake(int AnimalID, string AnimalName, double AnimalAge, Position AnimalPosition, double AnimalLength, bool AnimalVenomous) // constructor for Animal with ID, Name, Age, Length, and Venemous values
            : base(AnimalID, AnimalName, AnimalAge, AnimalPosition)
        {
			length = AnimalLength;
			venomous = AnimalVenomous;
		}
        public override string ToString() // prints all values of snake
        {
            return $" ID: {ID}, Name: {name}, Age: {age}, Position: ({pos.x}, {pos.y}, {pos.z}), Length: {length}, Venomous: {venomous}.";
}

