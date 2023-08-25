using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //Learning about variables, initialize player stats ;
            string playerName = "Goodlsy";
            uint playerHealth  = 100;
            string playerChoice;
            bool playerIsAlive = true;
            string enemyName = "Baddy G. Mcevilson";
            float WeaponDurability = 1.0f;
            int floornumber = 0;


            //Welcome Messages + Player name Input after Initializing
            Console.WriteLine("Whats good Galaxy");
            Console.WriteLine("JuJu");
            Console.WriteLine("Hello Whoever you are. What is your name?");
            Console.Write("> ");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + " " + lastName;
            
            //Starting to comment like Lodis said starting now. Display players name;
            Console.WriteLine("Welcome Then "+ playerName +" ...To The Tower!");
            
            Console.WriteLine("The Adventure Begins to defeat " + enemyName);

            //Initialize Weapon Stats

            string quarterstaff;
            string bigSword;
            string bunchOfKnives;

            //Here is where I'll Put initial Weapon Stats

            //comment out all highlighted is "ctrl,k,c" uncomment is "ctrl,k,u";
            //Opening Paragraph into The Tower itself; I realized too late
            Console.WriteLine("You enter a mountain cave after a long journey.");
            Console.WriteLine("Through the musty cave lit only by your lantern,");
            Console.WriteLine("you see a another lightsource. You walk closer.");
            Console.WriteLine("noticing it to be a glass door of some sort with");
            Console.WriteLine("a glowing sign above it. 'EVIL Inn and Suites.' ");
            Console.WriteLine("Confused you walk closer and the door slides open"); 
            Console.WriteLine("as if by magic. You walk into a well furnished.");
            Console.WriteLine("waiting room with red carpet and baige wallpaper.");
            Console.WriteLine("A Kobald dressed in a consierge get up stands behind");               
            Console.WriteLine("a desk 'Good Morning " + playerName +" have you come");
            Console.WriteLine("to check in? General Manager Mcevilson has been ");
            Console.WriteLine("expecting you.' What do you do?");
            
            //Here is where I'll put initial choice in the lobby on how to deal with
            //The Kobold doorman character. Need to use if, else if, and else statements
        }
    }
}
