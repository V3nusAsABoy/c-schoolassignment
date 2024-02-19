using System;
namespace cois2020assignment1
{
	public class Animal
	{
		public int ID { get; set; } // unique identifier of animal
		public string name { get; set; } // name of animal
        public double age { get; set; } // age in years of animal
        public Position pos { get; set; } // coordinates of animal
        public Animal(int AnimalID, string AnimalName, double AnimalAge, Position AnimalPosition) // constructor for Animal with ID, Name, Age and Position values
        {
			ID = AnimalID;
			name = AnimalName;
			age = AnimalAge;
			pos = AnimalPosition;
		}
	}
}

