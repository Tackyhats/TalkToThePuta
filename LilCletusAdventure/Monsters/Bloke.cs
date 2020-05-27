using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure.Monsters
{
    class Bloke : IAdversary
    {
        public int Mass { get; set; }
        public int Intelegence { get; set; }
        public int Attitude { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }

        public bool IsHairCool { get; set; }
        public Bloke()
        {
            Name = "Test";
            Mass = 20;
            Intelegence = 20;
            Attitude = 20;
            Health = 50;
        }
        public Bloke(string name, int mass, int intel, int att, int health)
        {
            Name = name;
            Mass = mass;
            Intelegence = intel;
            Attitude = att;
            Health = health;
        }
        public int Attack()
        {
            int attackDamage = Mass + 1;

            return attackDamage;
        }

    }
}
