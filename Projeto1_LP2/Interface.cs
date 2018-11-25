﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_LP2
{
    public class Interface : InterfaceManager
    {
        public Interface(string args) : base(args)
        {
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
        
    }
}
