using System.Collections.Generic;
using System.IO;

namespace Projeto1_LP2
{
    /// <summary>
    /// Class that will inherit a list of GamesInfo
    /// </summary>
    public class GamesList : List<GamesInfo>
    {
        /// <summary>
        /// Constructor that will receive the argument from the command line
        /// </summary>
        /// <param name="args"></param>
        public GamesList(string args)
        {
            // Will call for the AddGames() method, that receives that same argument
            AddGames(args);
        }

        /// <summary>
        /// Method that will add the games from the comand line's input
        /// </summary>
        /// <param name="args"></param>
        public void AddGames(string args)
        {
            // Streamreader instance will read the games.csv 
            using (StreamReader sr = new StreamReader(args))
            {
                // String that will serve for our while, as a condition
                string info = "";
                // Variable needed for a counter
                int srl = 0;
                
                // Cycle while that will run until the condition equals null
                while((info = sr.ReadLine()) != null)
                {
                    // Bool to check if the ID exists, starting as false
                    bool id_exists = false;
                    // If that will check if the counter isn't at 0
                    if (srl != 0)
                    {
                        // Created a new instance of GamesInfo()
                        GamesInfo gi = new GamesInfo(info);

                        // Foreach that will run through the list
                        foreach (GamesInfo g_info in this)
                        {
                            // If the id matches the game's ID
                            if (g_info.id == gi.id)
                            {
                                // The bool will become true
                                id_exists = true;
                            }
                        }

                        // If the ID doesn't exist
                        if (!id_exists)
                        {
                            // Will call the Add() method that receives gi
                            Add(gi);
                        }
                    }
                    // After each loop, it'll add 1 to the counter
                    srl++;
                }
            }

        }
    }
}
