using LilCletusAdventure.Monsters;
using System;

namespace LilCletusAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            LilCletus testCleet = new LilCletus();
            Bloke testBloke = new Bloke();
            Battle.RegularFight(testCleet, testBloke);

            //LilCletus character =  StoryLine.CharacterCreator();

            //character = StoryLine.GetWoke(character);

            //StoryLine.GetWoke(testCleet);



        }

    }
}










//-------------------------------------------------------------------------
         //   while (true)
            //{
             //   string answer = "";
             //   Console.WriteLine("How many gorillas to you rules over?");
             //   answer = Console.ReadLine();

             //   int num = 0;

             //   bool isNumber = int.TryParse(answer, out num);

             //   if (isNumber)
             //   {
              //      Console.WriteLine($"{answer}, Friggin Dope");
                //    break;
             //   }
               // else
             //   {
             //       Console.WriteLine($"{answer} isn't a number a dringus");
             //   }
          //  }

        //    bool keepGoing = true;
         //   while (keepGoing)
         //   {
          //      Console.WriteLine("What's the color of your back?");
          //      string answer = Console.ReadLine();
           //     answer = answer.ToLower();

           //     switch(answer)
           //     {
            //        case "silver":
            //            Console.WriteLine("Rad");
            //            break;
            //       case "brown":
             //           Console.WriteLine("You a softbody");
            //            break;
             ////       case "black":
             //           Console.WriteLine("Get outta here");
             //           break;
             //       case "yellow":
             //           Console.WriteLine("Not good enough");
             //           break;
             //       default:
             //           Console.WriteLine("I'm the one who decides which back color is best try again");
             //           continue;
             //   }
            //    keepGoing = false;
          //  }
            
      //  }
   

