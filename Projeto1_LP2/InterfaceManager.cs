using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_LP2
{
    public class InterfaceManager
    {
        public InterfaceManager(string args)
        {
            GamesList lst = new GamesList(args);
        }

        public int ReadEntry()
        {
            int read_number;

            while (true)
            {
                read_number = Convert.ToInt32(Console.ReadLine());
                int id;
                
                switch (read_number)
                {
                    case '1':
                        Console.WriteLine("Insert the game's ID, please. \n");

                        id = Console.Read();
                        Info(id);
                        break;

                    case '2':
                        Search();
                        break;

                    case '3':
                        return read_number;

                    default:
                        Console.WriteLine("Not a valid number. Try again.");
                        break;
                }
            }
        }
        public void Info(int id)
        {
            
        }

        private void Search()
        {
            int read_id;
            read_id = Console.Read();
        }
    }
}
