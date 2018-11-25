using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_LP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            InterfaceManager im = new InterfaceManager(args[0]);
            Interface menu = new Interface(args[0]);

            menu.ShowMenu();
        }
    }
}
