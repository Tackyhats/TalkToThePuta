using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    class Battle
    {
        public static void RegularFight(LilCletus lilCleet, IAdversary Bloke)
        {
            Console.WriteLine($"A wildly aggressive {Bloke.Name} appears!");
            while(true)
            {
                Console.WriteLine($"You have {Bloke.Health} health left");
                Console.WriteLine("What are you going to do about it?\n" +
                    "\n1 Bash him in\n" +
                    "\n2 Super run away");

                string response = Console.ReadLine();

                int cleetdmg = 0;
                int blokedmg = 0;

               
                if(response == "1")
                {
                    cleetdmg = lilCleet.Attack();
                    blokedmg = Bloke.Attack();
                }
                else if(response == "2")
                {
                  Random r = new Random();
                  int flipACoin = r.Next(1, 3);
                  if(flipACoin == 2)
                  {
                      Console.WriteLine("You trip and fall over your own Cleet feet");
                      cleetdmg = 0;
                      blokedmg = Bloke.Attack();
                  }
                  else
                  {
                      Console.WriteLine("You scuttled off");
                      break;
                  }
                }
                else
                {
                 Console.WriteLine("Enter a number between 1 and 2. You life is at stake here.");
                 Console.ReadKey();
                }
                Console.WriteLine($"You did {cleetdmg.ToString()}\n" +
                    $"{Bloke.Name} did {blokedmg.ToString()}");

                lilCleet.Health -= blokedmg;
                Bloke.Health -= cleetdmg;

                if(lilCleet.Health <=0 || Bloke.Health <=0)
                {
                    if(lilCleet.Health <= 0)
                    {
                        Console.WriteLine("YOU DIED");
                    }
                    else
                    {
                        Console.WriteLine($"{Bloke.Name} has been defeated. You bashed his fookin' head in I swear on me mum");
                    }
                    break;
                }

                ConsoleStuff.Break();
            }

        }


    }
}
