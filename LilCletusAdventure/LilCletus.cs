using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    class LilCletus
    {
        public string Name = "Lil Cletus";

        public int Mass { get; set; }
        public int Intelegence { get; set; }
        public int Attitude { get; set; }
        public int Health { get; set; }

        public List<Item> ItemBag; 

        public LilCletus()
        {
            Mass = 20;
            Intelegence = 20;
            Attitude = 20;
            Health = 100;
            ItemBag = new List<Item>();
        }
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

        public void checkItems()
        {
            if (ItemBag.Count == 0)
            {
                Console.WriteLine("Your pockets are empty");
            }
            else
            {
                for(int i = 0; i < ItemBag.Count; i++)
                {
                    Console.WriteLine(ItemBag[i].Name + " - " + ItemBag[i].Description);
                }
            }
        }
    }
}
