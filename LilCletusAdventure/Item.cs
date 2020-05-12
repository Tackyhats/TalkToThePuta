using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    class Item
    {
        public string Name;
        public string Description;
        public bool IsHarmful;

        public List<Buff> Buffs = new List<Buff>();

        public Item(string name, string description, bool isHarmful, List<Buff> buffs)
        {
            Name = name;
            Description = description;
            IsHarmful = isHarmful;
            Buffs = buffs;
        }
    }
}
