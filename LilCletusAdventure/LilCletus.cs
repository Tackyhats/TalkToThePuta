using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    class LilCletus
    {
        public string Name = "Lil Cletus";

        public int Mass;
        public int Intelegence;
        public int Attitude;
        public int Health;

        public List<Item> ItemBag; 

        public LilCletus(int mass, int intel, int att, int health)
        {
            Mass = mass;
            Intelegence = intel;
            Attitude = att;
            Health = health;
            ItemBag = new List<Item>();
        }

        public int Attack()
        {
            int attackDamage = Mass + 2;

            return attackDamage;
        }

        public void AddItem(Item inventory)
        {
            if(ItemBag.Count <= 10)
            {
                ItemBag.Add(inventory);
            }
            else
            {
                Console.WriteLine("Your pockets are full amigaa");
            }
        }


    }
}
