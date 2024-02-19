using System;
using System.Collections;
using System.Collections.Generic;

namespace cois2020assignment1;

// Andrew Abdulaziz
// StudentID: 0769573
/* This is an project that generates animals, traits for the animals, and their positions. The 2 types of animals it generates are cats
 * and snakes. It will randomly generate 3 cats and 3 snakes, and put them in a list and in an array and a list. It will traverse the list
 * and array showing the properties of each animal. Then it will move the positions of each animal and show the properties again.
 */

class Program
{
    public static void Main()
    {
        StreamReader cat = new StreamReader("/Users/andrewabdulaziz2/Library/Mobile Documents/com~apple~TextEdit/Documents/catnames.txt"); // imports cat names
        StreamReader snake = new StreamReader("/Users/andrewabdulaziz2/Library/Mobile Documents/com~apple~TextEdit/Documents/snakenames.txt"); // imports snake names

        string oneCat = string.Empty; // object for lines in cat names file
        string oneSnake = string.Empty; // object for lines in snake names file
        string[] cats = new string[100]; // array containing all cat names
        string[] snakes = new string[34]; // array containing all snake names
        int index = 0; // index value that increases by 1, representing each line in cat names file. Each line will be added to the array.
        int index2 = 0; // index value that increases by 1, representing each line in snake names file. Each line will be added to the array.

        // adds cat names to cats array
        while ((oneCat = cat.ReadLine()) != null)
        {
            cats[index] = oneCat;
            index++;
        }

        // adds snake names to snakes array
        while ((oneSnake = snake.ReadLine()) != null)
        {
            snakes[index2] = oneSnake;
            index2++;
        }

        // array for 3 numbers. For each number n in the array, the nth line in the cat names file will be selected for a cat's name.
        int[] catNames = new int[3];

        // array for 3 numbers. For each number n in the array, the nth line in the snake names file will be selected for a snake's name.
        int[] snakeNames = new int[3];

        // array for 3 numbers. For each number n in the array, the nth breed out of the breeds enum will be selected for a cat's breed.
        int[] breedTypes = new int[3];

        var random = new Random(); // imports random

        catNames[0] = random.Next(0, 100); // sets the value for first index of catNames array

        // sets values for other 2 indexes of catNames array. Also makes sure they don't = one of the other ones
        for (int i = 1; i < 3; i++) {
            catNames[i] = random.Next(0, 100);
            // if it 1 catNames[i] == catNames[i - 1], the value of catNames[i] will have 1 added to it, unless it is equal to 99 so it will have 1 subtracted from it
            if (catNames[i] == catNames[i - 1])
            {
                if (catNames[i] == 99)
                    catNames[i]--;
                else
                    catNames[i]++;
            }
        }

        snakeNames[0] = random.Next(0, 35); // sets the value for first index of snakeNames array

        // sets values for other 2 indexes of snakeNames array. Also makes sure they don't = one of the other ones
        for (int i = 1; i < 3; i++) {
            snakeNames[i] = random.Next(0, 35);
            // if it 1 snakeNames[i] == snakeNames[i - 1], the value of snakeNames[i] will have 1 added to it, unless it is equal to 34 so it will have 1 subtracted from it
            if (snakeNames[i] == snakeNames[i - 1])
        {
            if (snakeNames[i] == 34)
                snakeNames[i]--;
            else
                snakeNames[i]++;
        }
    }

        var breeds = (Breed[])Enum.GetValues(typeof(Breed)); // initializing array containing all values of enum property breed

        breedTypes[0] = random.Next(0, 6); // sets the value for first index of catNames array

        // sets values for other 2 indexes of breedTypes array. Also makes sure they don't = one of the other ones
        for (int i = 1; i < 3; i++)
        {
            // sets values for other 2 indexes of breedTypes array. Also makes sure they don't = one of the other ones
            breedTypes[i] = random.Next(0, 6);
            // if it 1 breedTypes[i] == breedTypes[i - 1], the value of breedTypes[i] will have 1 added to it, unless it is equal to 6 so it will have 1 subtracted from it
            if (breedTypes[i] == breedTypes[i - 1])
            {
                if (breedTypes[i] == 6)
                    breedTypes[i]--;
                else
                    breedTypes[i]++;
            }
        }

        // array for 3 bools determining if a snake is venemous.
        bool[] venom = new bool[3];

        // randomly generating values for venom
        for(int i = 0; i < 3; i++)
        {
            int b = random.Next(0, 2);
            if (b == 0)
                venom[i] = true;
            else
                venom[i] = false;

        }

        // Creates empty Positin objects for cat1Pos, cat2Pos, and so on then uses the randomPos method to randomize them
        Position cat1Pos = new Position(0, 0, 0);
        Position.randomPos(cat1Pos);

        Position cat2Pos = new Position(0, 0, 0);
        Position.randomPos(cat2Pos);

        Position cat3Pos = new Position(0, 0, 0);
        Position.randomPos(cat3Pos);

        Position snake1Pos = new Position(0, 0, 0);
        Position.randomPos(snake1Pos);

        Position snake2Pos = new Position(0, 0, 0);
        Position.randomPos(snake2Pos);

        Position snake3Pos = new Position(0, 0, 0);
        Position.randomPos(snake3Pos);


        // instantiates several cat and snake objects, completely randomizing all the values
        Cat cat1 = new Cat(1, cats[catNames[0]], Math.Round(random.NextDouble() * (0 - 15.0) + 15.0, 2), cat1Pos, breeds[breedTypes[0]]);
        Cat cat2 = new Cat(2, cats[catNames[1]], Math.Round(random.NextDouble() * (0 - 15.0) + 15.0, 2), cat2Pos, breeds[breedTypes[1]]);
        Cat cat3 = new Cat(3, cats[catNames[2]], Math.Round(random.NextDouble() * (0 - 15.0) + 15.0, 2), cat3Pos, breeds[breedTypes[2]]);
        Snake snake1 = new Snake(4, snakes[snakeNames[0]], Math.Round(random.NextDouble() * (0 - 30.0) + 30.0, 2), snake1Pos, Math.Round(random.NextDouble(), 2), venom[0]);
        Snake snake2 = new Snake(5, snakes[snakeNames[1]], Math.Round(random.NextDouble() * (0 - 30.0) + 30.0, 2), snake2Pos, Math.Round(random.NextDouble(), 2), venom[1]);
        Snake snake3 = new Snake(6, snakes[snakeNames[2]], Math.Round(random.NextDouble() * (0 - 30.0) + 30.0, 2), snake3Pos, Math.Round(random.NextDouble(), 2), venom[2]);

        // creating list and array containing all animals
        ArrayList animalList = new ArrayList() { cat1, cat2, cat3, snake1, snake2, snake3 };
        Animal[] animalArray = new Animal[] { cat1, cat2, cat3, snake1, snake2, snake3 };

        Console.WriteLine("Every element in array before move:\n");

        // traverses array to print all details of every animal in the array before the positions get moved
        foreach (Animal a in animalArray)
        {
            Console.WriteLine(a.ToString());
        }

        // uses Move operator to move the position of every animal in array by a random value
        foreach (Animal a in animalArray)
        {
            Position.Move(Math.Round(random.NextDouble() * (-2.0 - 2.0) + 2.0, 2), Math.Round(random.NextDouble() * (-2.0 - 2.0) + 2.0, 2), Math.Round(random.NextDouble() * (-2.0 - 2.0) + 2.0, 2), a.pos);
        }

            Console.WriteLine("\nEvery element in array after move:\n");

        // traverses array to print all details of every animal in the array in array after the positions got moved
        foreach (Animal a in animalArray)
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\nEvery element in list before move:\n");

        // traverses list to print all details of every animal in the list before the positions get moved
        foreach (Animal a in animalList)
        {
            Console.WriteLine(a.ToString());
        }

        // uses Move operator to move the position of every animal in list by a random value
        foreach (Animal a in animalList)
        {
            Position.Move(Math.Round(random.NextDouble() * (-2.0 - 2.0) + 2.0, 2), Math.Round(random.NextDouble() * (-2.0 - 2.0) + 2.0, 2), Math.Round(random.NextDouble() * (-2.0 - 2.0) + 2.0, 2), a.pos);
        }

        Console.WriteLine("\nEvery element in list after move:\n");

        // traverses list to print all details of every animal in the list in array after the positions got moved
        foreach (Animal a in animalList)
        {
            Console.WriteLine(a.ToString());
        }

        Console.ReadLine();
    }
}

