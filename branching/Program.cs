using System;
using System.IO;
using System.Text.Json;




// The below function is getting and setting the data from this file to in built .json file
public class GameStats
{
    public int Wins { get; set; }
    public int Losses { get; set; }
}








//Just a simple program which will help you understand the if else statements in C#

public class Program
{
    public static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        GameStats stats; //here we are declaring a variable(stats)of type GameStats to hold the game statistics

        string filePath = "stats.json";//declaring (filePath) variable to hold the path of the JSON file

        if (File.Exists(filePath)) // Check if the file exists
        {
            Console.WriteLine("Loading.........");
            Console.Write("......");
            Console.Write("......");
            Console.Write("......");
            string jsonString = File.ReadAllText(filePath);/*we are declaring a string variable
            name jsonString which holds the contents of the JSON file*/

            stats = JsonSerializer.Deserialize<GameStats>(jsonString);// here we are deserializing the JSON string into the GameStats object
            //meaning that we are converting the JSON string back into a GameStats object
        }
        else
        {
            stats = new GameStats { Wins = 0, Losses = 0 }; // If the file doesn't exist, create a new GameStats object
            Console.WriteLine("No previous game data found. Starting fresh.");
        }




        int userKey = -1; // Initialize to avoid unassigned variable error
        string userInput = "";
        while (true)
        {
            int keyTounlock = randomGenerator.Next(1, 4);
            Console.WriteLine($"Stats - Wins: {stats.Wins}, Losses: {stats.Losses}");
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Key Unlock Game!");
            Console.WriteLine("You are against a door with a keyhole.");
            Console.WriteLine("You have three keys: 1, 2, and 3.");
            try
            {
                Console.WriteLine("Enter the key number you want to try (1, 2, or 3 and 4 to quit, 5 to reset):");

                userInput = Console.ReadLine();
                if (userInput == null)
                {
                    throw new FormatException();
                }
                bool check = int.TryParse(userInput, out userKey);
                if (check && (userKey == 1 || userKey == 2 || userKey == 3))
                {
                    Console.WriteLine("Key is placed!");
                }
                else if (userKey == 4)
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    break; // Exit the loop if the user enters 4
                }
                else if (userKey == 5)
                {
                    Console.WriteLine("Resetting game stats to zero.");
                    stats.Wins = 0;
                    stats.Losses = 0;
                    break; // Reset the stats!
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid key number (1, 2, or 3).");
                continue; // Skip the rest of the loop and prompt again
            }
            if (userKey == keyTounlock)
            {
                Console.WriteLine("Congratulations! You unlocked the door.");
                stats.Wins++;
            }
            else
            {
                Console.WriteLine("Wrong key! Try again.");
                stats.Losses++;
            }
            //
            string updatedJsonString = JsonSerializer.Serialize(stats);

            File.WriteAllText(filePath, updatedJsonString);



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }
    }

}
