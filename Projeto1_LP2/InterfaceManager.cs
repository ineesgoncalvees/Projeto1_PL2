using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_LP2
{
    public class InterfaceManager
    {
        Interface i;
        GamesList lst;

        public InterfaceManager() { }

        public InterfaceManager(string args)
        {
            lst = new GamesList(args);
            i = new Interface();
            i.ShowMenu();
        }

        public int ReadEntry()
        {
            string read_number;            

            while (true)
            {
                read_number = Console.ReadLine();
                int id;
                
                switch (read_number)
                {
                    case "1":
                        Console.WriteLine("Insert the game's ID, please. \n");
                        id = Console.Read();
                        CheckID(id);
                        break;

                    case "2":
                        Search();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a valid number. Try again.");
                        Console.ReadLine();
                        i.ShowMenu();
                        break;
                }
            }
        }

        public void CheckID(int id) {
            
            foreach (GamesInfo gi in lst) 
            {
                if (gi != null) 
                {
                    if (gi.id == id) 
                    {
                        Console.WriteLine(gi.ToString());
                    }
                }
            }
        }

        private void Search()
        {
            int read_id;
            read_id = Console.Read();
        }
    }
}
