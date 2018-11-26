using System;

namespace Projeto1_LP2
{
    /// <summary>
    /// Class that will manage what the user sees and inputs
    /// </summary>
    public class InterfaceManager
    {
        // Will start the instance here
        GamesList lst;

        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="args"></param>
        public InterfaceManager(string args)
        {
            // Will create lst as a new object of GamesList
            lst = new GamesList(args);
            // Will call the ShowMenu() method
            ShowMenu();
        }

        /// <summary>
        /// A method that will render the menu to the player
        /// </summary>
        public void ShowMenu()
        {
            Console.WriteLine("╔═══*.·:·.**  < x >  **.·:·.*═══╗");
            Console.WriteLine();
            Console.WriteLine("       1. Show game's info\n" +
                              "       2. Make a research\n" +
                              "       3. Leave\n");
            Console.WriteLine("╚═══*.·:·.**  < x >  **.·:·.*═══╝");

            // Will call the ReadEntry() method
            ReadEntry();
        }

        /// <summary>
        /// Method that will read the player's input and act accordingly
        /// </summary>
        /// <returns></returns>
        public int ReadEntry()
        {
            // A loop that will run while the condition is true, and while the
            // player doesn't choose to leave
            while (true)
            {
                // A variable needed for the cases
                int id;
                
                // A switch case that will work based on the player's input
                switch (Console.ReadLine())
                {
                    // If the player chooses 1
                    case "1":
                        // Will ask for the ID
                        Console.WriteLine("Insert the game's ID, please. \n");
                        // Will save the input, place it on id and then convert it
                        id = Convert.ToInt32(Console.ReadLine());
                        // Will call for the CheckID() method
                        CheckID(id);
                        break;

                    // If the player chooses 2
                    case "2":
                        // Will call for the Seach() method
                        Search();
                        break;

                    // If the player chooses 3
                    case "3":
                        // Will break the loop and exit the program
                        Environment.Exit(0);
                        break;

                    // A default message in case the player chooses an
                    // unavailable number
                    default:
                        // Will print an error message, and ask them to type a
                        // number again
                        Console.WriteLine("Not a valid number. Try again.");
                        // Reads the input
                        Console.ReadLine();
                        // Will clear the console
                        Console.Clear();
                        // Calls for the ShowMenu() method
                        ShowMenu();
                        break;
                }
            }
        }

        /// <summary>
        /// Method that will check the ID
        /// </summary>
        /// <param name="id"></param>
        public void CheckID(int id) {
            
            // Foreach that will run through the list searching for IDs
            foreach (GamesInfo gi in lst) 
            {
                // If gi is different from null
                if (gi != null) 
                {
                    // Will match the gi's ID to the ID
                    if (gi.id == id) 
                    {
                        // And print the ToString based on the gi's ID
                        Console.WriteLine(gi.ToString());
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// A search method that would serve for the second option on the menu
        /// </summary>
        private void Search()
        {
            Console.WriteLine("Search for the games on steam here. (Under" +
                "constrution)");
        }
    }
}
