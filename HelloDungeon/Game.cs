using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {

        //


        //function to Add stuff together
        float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }


        //function to print out player's stats, conjunction junction what's your function;
        void PrintsStats(string name, float health, float damage, float strength)
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

        string DisplayMenu(string prompt, string option1, string option2, string option3, string option4)
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
                Console.WriteLine("3. " + option3);
                Console.WriteLine("4. " + option4);

               //get player input
                Console.Write("> ");
                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3" && playerChoice != "4")
                {
                    // error message if statement
                    Console.Clear();
                    Console.WriteLine("Idk what you want from me, but that wasn't right...");
                    Console.WriteLine("Press anything to try again please");
                    Console.ReadKey(true);
                }
            

            }

            return playerChoice;
        }


        public void Run()

        {
            CountEvens(0, 5);


            {
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

                        Console.WriteLine("Are you sure you want to do this? This technically chooses your class...");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");


                        //playerChoice = Console.ReadLine();


                        //playerChoice = " ";
                        //while (playerChoice != "1" && playerChoice != "2")
                        //{
                        //    Console.WriteLine("1. Yes");
                        //    Console.WriteLine("2. No");
                        //    Console.WriteLine(">");
                        //    playerChoice = Console.ReadLine();


                        //    if (playerChoice == "2")
                        //    {
                        //        //gameOver = true;
                        //    }
                        //    else if (playerChoice != "1")
                        //    {
                        //        Console.WriteLine("Invalid Input");
                        //    }
                        }
                    }

                }
            }
        }// \n THIS MEANS YOU CAN SKIP A FUCKING LINE IN DIALOGUE HOLY SHIT THATS SO MUCH EASIER!!!!~~!~!~!@!~@$!@##%@!%`23VB HH BH
    }

