using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    class Buff
    {
        public string Buffname;
        public int Modifier;

        public Buff(string buffname, int modifier)
        {
            Buffname = buffname;
            Modifier = modifier;
        }
    }
}
