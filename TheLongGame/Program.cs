using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;

namespace TheLongGame
{

    public class User
    {
        public string name;
        public int score; 
        public User(string name, int score) {
            this.name = "N/A";
            this.score = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //When the program starts, ask the user to enter their name.
           Console.WriteLine("Hi! Please enter your name:");
          string newName = Console.ReadLine();

            //change so newName is var not string
            if (File.Exists("newName.txt"){
                File.OpenRead("newName.txt");
                User user = new User(newName, )
            }

            User user = new User(newName, 0);

            Console.WriteLine("Hello, " + newName + "! Your current score is " + user.score + ". Press a key to add to your score, or press enter to exit.");

          
           // By default, the player starts with a score of 0.
           // Add 1 point to their score for every keypress they make.
           // Display the player’s updated score after each keypress.
           // When the player presses the Enter key, end the game.
                // Hint: the following code reads a keypress and checks whether it was the Enter key: Console.ReadKey().Key == ConsoleKey.Enter
          //  When the player presses Enter, save their score in a file.
                // Hint: Consider saving this to a file named[username].txt.For this challenge, you can assume the user doesn’t enter a name that would produce an illegal file name(such as *).
          //  When a user enters a name at the start, if they already have a previously saved score, start with that score instead.
        }
    }
}
