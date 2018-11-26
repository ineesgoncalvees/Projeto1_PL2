using System;

namespace Projeto1_LP2
{
    public class InterfaceManager
    {
        GamesList lst;

        public InterfaceManager() { }

        public InterfaceManager(string args)
        {
            lst = new GamesList(args);
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine("╔═══*.·:·.**  < x >  **.·:·.*═══╗");
            Console.WriteLine();
            Console.WriteLine("       1. Show game's info\n" +
                              "       2. Make a research\n" +
                              "       3. Leave\n");
            Console.WriteLine("╚═══*.·:·.**  < x >  **.·:·.*═══╝");

            ReadEntry();
        }

        public int ReadEntry()
        {
            while (true)
            {
                int id;
                
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Insert the game's ID, please. \n");
                        id = Convert.ToInt32(Console.ReadLine());
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
                        Console.Clear();
                        ShowMenu();
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
                        break;
                    }
                }
            }
        }

        private void Search()
        {
            Console.WriteLine("Search for the games on steam here. (Under" +
                "constrution)");
        }
    }
}
