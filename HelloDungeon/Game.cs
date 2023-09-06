using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //Learning about variables and how to utilizer scope better. putting this at the top before class Game...
        //makes it to where these variables are in scope for the rest of my game, initialize player stats and starting variables here;
        string playerName = "";
        string playerClass = "";
        uint playerHealth = 10;
        int currentScene = 0;
        float playerDamage = 0;
        string playerChoice = "";
        bool playerIsAlive = true;
        string enemyName = "";
        bool gameOver = false;
        //Initialize Weapon Stats

        string quarterstaff;
        string bigSword;
        string bunchOfKnives;


        //white variables = member variables/global variables meaning they are in a greater scope enough to be used through out code
        //blue variables = variables inside of a function which are local variables meaning they only apply inside the scope of a function



        //function to Add stuff together
        float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }


        //function to print out player's stats, conjunction junction what's your function;
        void PrintStats(string name, float health, float damage, float strength)
        {
            Console.WriteLine(name);
            Console.WriteLine(health);
            Console.WriteLine(damage);
            Console.WriteLine(strength);

        }

        //Create a Function that can take in two integers.
        //it should return the value that is greatger
        //Input: 40, 42
        // Output: 42

        int PrintGreaterNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        //new challenge  Create a function that takes in one integer
        ///It shoule print to the conasol allnumbers between 0 and that integer. 
        ///Extra Challenge: Don't use a while loop.
        ///Input: 5 
        ///Output 0, 1, 2, 3, 4, 5.

        int Count(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
            return a;
        }
        //Create Function that takes in two integer
        ///it should print to the console all even numbersa b/t 
        ///the 1st and 2nd integer.
        ///input: 0,5 
        ///output: 0,2,4

        void CountEvens(int a, int b)
        {
            for (int i = a; a <= b; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }

            }

        }
        // Making a function to display menu with 4 options for player input.
        // if player input is not one of the available options ten display the error message.
        // when i want to use this i'll just need to put stuff for the strings aka prompt and the option1 - option4.


        string DisplayPrompt(string prompt, string option1, string option2, string option3, string option4, string outcome1, string outcome2, string outcome3, string outcome4)
        {
            string playerChoice = " ";
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3" && playerChoice != "4")
            {
                //display prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //display options
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);

                if (option3 != "")
                {
                    Console.WriteLine("3. " + option3);
                }
                if (option4 != "")
                {
                    Console.WriteLine("4. " + option4);
                }
                //get player input
                Console.Write("> ");
                playerChoice = Console.ReadLine();
                //Display outcome
                if (playerChoice == "1")
                {
                    Console.WriteLine(outcome1);
                }
                if (playerChoice == "2")
                {
                    Console.WriteLine(outcome2);
                }
                if (playerChoice == "3")
                {
                    Console.WriteLine(outcome3);
                }
                if (playerChoice == "4")
                {
                    Console.WriteLine(outcome4);
                }

                if (playerChoice != "1" && playerChoice != "2")
                {
                    // if player input is no one of the available options
                    if (playerChoice == "3" && playerChoice != "")
                    {
                        continue;
                    }
                    if (playerChoice == "4" && playerChoice != "")
                    {
                        continue;
                    }
                    // error message if statement, making playerChoice and empty string again makes the loop return to the top.
                    Console.Clear();
                    Console.WriteLine("Idk what you want from me, but that wasn't right...");
                    Console.WriteLine("Press anything to try again please");
                    Console.ReadKey(true);
                    playerChoice = "";
                }


            }

            return playerChoice;
        }
        // creating Main Menu and Display it on screen
        void DisplayMainMenu_Scene0()
        {
            playerChoice = " ";
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
                    Console.WriteLine("Welcome Then " + playerName + " ...To The Tower of Baddy !");
                    Console.ReadKey(true);
                    Console.WriteLine("The Adventure Begins...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                if (playerChoice == "2")
                {
                    Console.WriteLine("Well you can so how about you try again?");
                    Console.WriteLine("What's your name?");

                }
                if (playerChoice != "1" && playerChoice != "2")
                {

                    Console.WriteLine("Invalid Input");
                    Console.ReadKey(true);
                   
                    //Starting to comment like Lodis said starting now. Display players name;
                    
                }
            }
            currentScene = 1;

        }
       
        // Lobby with Kobold scene
        void DisplayScene1()
        {
            //comment out all highlighted is "ctrl,k,c" uncomment is "ctrl,k,u";
            //Opening Paragraph into The Game itself; I realized too late there was an easier way to do this;
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
            Console.WriteLine("What Will you do " + playerName + "?");
            Console.WriteLine("1. Attack Him");
            Console.WriteLine("2. Talk to Him");
            Console.WriteLine("3. Sneak around Him");
            Console.WriteLine("4. Do Magic at Him");
            Console.WriteLine(">");


            playerChoice = ("");

            //made loop here. 
            //need to change text later
            while (playerChoice != "yes")
            {
               
                playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    Console.WriteLine("kill guy temp text");
                    
                }

                if (playerChoice == "2")
                {
                    Console.WriteLine("speak to guy temp text");

                }
                if (playerChoice == "3")
                {
                    Console.WriteLine("sneak passed guy temp text");
                }
                if (playerChoice == "4")
                {
                    Console.WriteLine("magic the guy temp text");
                }
                currentScene = 2;
                return;
            }

            

        }
        // Walking down the hall
        void DisplayScene2 ()
        {
            Console.ReadKey(true);
            //scene set up dialogue
            Console.WriteLine("You make your way to an elevator with only an Up button in it so you press it.\n" +
                "you travel a surpisingly long time with hypnotically bland and dreadfully unoffensive music playing.\n " +
                "Suddenly with a loud DING sound the door opens and you are greeted with a long hallway with patterned wallpaper.\n" +
                "You walk down looking at your roomkey looking for your room number realizing the key doesn't have one... \n");
          
            Console.ReadKey(true);
            //Using DisplayPrompt function which lets me make prompt and outcome for story based entries;
            DisplayPrompt(" You come to a intersection and looking around see only 4 doors in each direction. " +
                "Which room do you try to enter?", "3", "667", "42", "V",
                "Lucky number tmp txt","number of the beast joke tmp txt","meaning of life joke tmp txt", "Roman numeral joke");
            Console.ReadKey (true);
            Console.WriteLine("You go to sleep and plan to finish the adventure later.");
            Console.ReadKey(true);
        }

        public void Run()

        {

            //loop to run any scene in game;
            while (gameOver != true)
            {
                if (currentScene == 0)
                {
                    DisplayMainMenu_Scene0();
                }
                if (currentScene == 1)
                {
                    DisplayScene1();
                }
                if (currentScene == 2)
                {
                    DisplayScene2();
                }

                // No idea if this continue/End Loop works
                playerChoice = " ";
                while (playerChoice != "1" && playerChoice != "2")
                {
                    Console.WriteLine("Thanks for playing! Would you like to play again?");
                    Console.WriteLine("1. yes");
                    Console.WriteLine("2. no");
                    Console.WriteLine(">");
                    playerChoice = Console.ReadLine();

                    //Basically setting up game over loop would you like to continue etc. don't fully get how this while loop works

                    if (playerChoice == "2")
                    {
                        gameOver = true;
                    }
                    if (playerChoice == "1")
                    {
                        gameOver = false;
                        currentScene = 0;
                        continue;
                    }
                }



            }
        }
    }
}        
        
        
        
        
        
        
        
        
        
        
        // ctrl, m, o, = collapse all functions
        // ctrl, m, p, = expand all functions
        // \n THIS MEANS YOU CAN SKIP A FUCKING LINE IN DIALOGUE HOLY SHIT THATS SO MUCH EASIER!!!!~~!~!~!@!~@$!@##%@!%`23VB HH BH