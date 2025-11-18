using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Xml.Linq;

namespace TheLongGame
{

    //class that holds current user's name and score
    public class User
    {
        public string name;
        public int score; 
        // By default, the player starts with a score of 0.
        public User(string name) {
            this.name = name;
            this.score = 0;
        }

        public void UpdateScore(StreamWriter writer)
        {
            writer.Write(this.score);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //When the program starts, ask the user to enter their name.
            Console.WriteLine("Hi! Please enter your name:");
            string newName = Console.ReadLine();

            User user = new User(newName);

            string path = "../../../" + newName + ".txt";

            //  When a user enters a name at the start, if they already have a previously saved score, start with that score instead.
            //if name alr exists, retrieve .txt file
            if (File.Exists(path)){
                using (StreamReader reader = new StreamReader(path))
                {
                    //retrieve existing score
                    user.score = int.Parse(reader.ReadLine());
                }
            }
            else //create new file for user
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    user.UpdateScore(writer);
                }
                   
                };

              Console.WriteLine("Hello, " + newName + "! Your current score is " + user.score + ". Press a key to add to your score, or press enter to exit.");
             // Add 1 point to their score for every keypress they make.
                do {
                    user.score++;
             // Display the player’s updated score after each keypress.
                Console.WriteLine("Your score is now " + user.score + ". Press a key to add to your score, or press enter to exit.");
                } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

             // When the player presses the Enter key, end the game.
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Your final score is " + user.score + ". Thanks for playing!");
              // When the player presses Enter, save their score in a file.
              //recreate text file and add updated score
               using (StreamWriter writer = new StreamWriter(path,false))
                {
                    user.UpdateScore(writer);
                }
            }
  
            }
        }
}
