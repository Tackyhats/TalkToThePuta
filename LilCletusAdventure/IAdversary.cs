using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    interface IAdversary
    {
 // Monsters will inherit from this class
       public string Name { get; set; }
        public int Mass { get; set; }
        public int Intelegence { get; set; }
        public int Attitude { get; set; }
        public int Health { get; set; }

        public int Attack();

    }
}
