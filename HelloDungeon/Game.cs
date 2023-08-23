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
            // DAY ONE: Learning about variables;
            string playerName = "Goodlsy";
            uint playerHealth  = 100;
            bool playerIsAlive = true;
            string enemyName = "Baddy G. Mcevilson";
            float WeaponDurability = 1.0f;
            int floornumber = 0;

            // DAY TWO: Welcome Messages + Player name Input after Initializing
            Console.WriteLine("Whats good Galaxy");
            Console.WriteLine("JuJu");
            Console.WriteLine("Hello Whoever you are. What is your name?");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + " " + lastName;
            
            //Starting to comment like Lodis said starting now. Display players name;
            Console.WriteLine("Welcome Then "+ playerName +" ...To The Tower!");
            Console.WriteLine("The Adventure Begins to defeat " + enemyName);

        }
    }
}
