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
            string playerName = "";
            uint playerHealth = 100;
            string playerChoice = "";
            bool playerIsAlive = true;
            string enemyName = "Baddy G. Mcevilson";
            float WeaponDurability = 1.0f;
            int floornumber = 0;


            //Welcome Messages + Player name Input after Initializing
            Console.WriteLine("Whats good Galaxy");
            Console.WriteLine("JuJu");
            Console.WriteLine("Hello Whoever you are. What is your name?");
            Console.Write("> ");





            while (playerChoice != "1")
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();

                playerName = firstName + " " + lastName;

                Console.WriteLine("Really? " + playerName + "  ? You know you can choose whatever name you want right?");

                //confirm player name choice
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                playerChoice = Console.ReadLine();
                Console.Clear();
                if (playerChoice == "1")
                {
                    Console.WriteLine("And you decided " + playerName + " was your best option? Well it's not my name so whatever...");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Well you can so how about you try again?");
                    Console.WriteLine("What's your name?");

                }
                else
                {

                    Console.WriteLine("Invalid Input");
                    Console.ReadKey(true);
                }
            }




            //Starting to comment like Lodis said starting now. Display players name;
            Console.WriteLine("Welcome Then " + playerName + " ...To The Tower!");
            Console.ReadKey(true);
            Console.WriteLine("The Adventure Begins to defeat " + enemyName);
            Console.ReadKey(true);
            Console.Clear();
            //Initialize Weapon Stats

            string quarterstaff;
            string bigSword;
            string bunchOfKnives;

            //Here is where I'll Put initial Weapon Stats

            //comment out all highlighted is "ctrl,k,c" uncomment is "ctrl,k,u";
            //Opening Paragraph into The Tower itself; I realized too late there was an easier way to do this;
            Console.WriteLine("You enter a mountain cave after a long journey.");
            Console.ReadKey(true);
            Console.WriteLine("Through the musty cave lit only by your lantern,");
            Console.ReadKey(true);
            Console.WriteLine("you see a another lightsource. You walk closer.");
            Console.ReadKey(true);
            Console.WriteLine("noticing it to be a glass door of some sort with");
            Console.ReadKey(true);
            Console.WriteLine("a glowing sign above it. 'EVIL Inn and Suites.' ");
            Console.ReadKey(true);
            Console.WriteLine("Confused you walk closer and the door slides open");
            Console.ReadKey(true);
            Console.WriteLine("as if by magic. You walk into a well furnished.");
            Console.ReadKey(true);
            Console.WriteLine("waiting room with red carpet and baige wallpaper.");
            Console.ReadKey(true);
            Console.WriteLine("A Kobald dressed in a consierge get up stands behind");
            Console.ReadKey(true);
            Console.WriteLine("a desk 'Good Morning " + playerName + " have you come");
            Console.ReadKey(true);
            Console.WriteLine("to check in? General Manager Mcevilson has been ");
            Console.ReadKey(true);
            Console.WriteLine("expecting you.");
            Console.ReadKey(true);

            //Here is where I'll put initial choice in the lobby on how to deal with
            //The Kobold doorman character. Need to use if, else if, and else statements
            //Also need to set up for loops to do combat sequence;
            //Goal get while loops for every decision player makes and use loop to repeat game. possibly...
            //the continue function

            Console.Clear();
            Console.WriteLine("What Will you do " + playerName +"?");
            Console.WriteLine("1. Attack Him");
            Console.WriteLine("2. Talk to Him");
            Console.WriteLine("3. Sneak around Him");
            Console.WriteLine("4. Do Magic at Him");
            Console.WriteLine(">");

            
            playerChoice = ("");

            while (playerChoice != "yes")
            {

                playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    Console.WriteLine("kill guy temp text");
                }

                else if (playerChoice == "2")
                {
                    Console.WriteLine("speak to guy temp text");
                }
                else if (playerChoice == "3")
                {
                    Console.WriteLine("sneak passed guy temp text");
                }
                else if (playerChoice == "4")
                {
                    Console.WriteLine("magic the guy temp text");
                }

                Console.WriteLine("Are you sure you want to do this.");
                Console.WriteLine("yes");
                Console.WriteLine("no");

                playerChoice = Console.ReadLine();
            } 

        }
    }
}
