using System;

namespace TalkToThePuta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepare your cheeks for adventure Lil Cleetus");

            Console.WriteLine("It is time to approprite your Cleet deets");

            int pointsToSpend = 10;

            int mass = 5;
            int intellegence = 5;
            int attitude = 5;
            int health = 10;

          
            string sMass = mass.ToString();
            string sIntel = intellegence.ToString();
            string sAtt = attitude.ToString();
            string sHealth = health.ToString();
            string sPoints = pointsToSpend.ToString();

            Console.WriteLine("Here are your stats:\n\n" +
                $"1.    Mass:           {sMass} \n" +
                $"2.    Intellegence    {sIntel}\n" +
                $"3.    Attitude        {sAtt}\n" +
                $"4.    Health          {sHealth}\n");

            Console.WriteLine($"You have {sPoints} good boy points\n Enter how many to goop up" +
                "for Mass:");

            while (true)
            {
                Console.WriteLine($"Enter a number 1 to {sPoints}");
                string sAnswer = Console.ReadLine();

                int pointsToAdd = 0;

                bool isNumber = int.TryParse(sAnswer, out pointsToAdd);

                if (isNumber)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        mass += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sMass = mass.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"That's not a number between 0 and {pointsToSpend} ya dringus");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number dringus");
                    continue;
                }          



            }


            Console.Clear();
            Console.WriteLine("Here are your stats:\n\n" +
                $"1.    Mass:           {sMass} \n" +
                $"2.    Intellegence    {sIntel}\n" +
                $"3.    Attitude        {sAtt}\n" +
                $"4.    Health          {sHealth}\n");
            Console.WriteLine($"You have {pointsToSpend} good boy points to spend!");



            while (true)
            {
             Console.WriteLine("How smart ams you");
             string sAnswer = Console.ReadLine();

                int pointsToAdd = 0;
                bool isNumber = int.TryParse(sAnswer, out pointsToAdd);

                if (isNumber == true)
                { 
                  if (pointsToAdd >= 0 && pointsToSpend >= pointsToAdd)
                    {
                        intellegence += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sIntel = intellegence.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You too astupid to add that many");
                        continue;
                    }
                } 
            else
                 {
                   Console.WriteLine("You don't even know what numbers are");
                   continue;
                 }


            }
                Console.Clear();
                Console.WriteLine("Here are your stats:\n\n" +
                    $"1.    Mass:           {sMass} \n" +
                    $"2.    Intellegence    {sIntel}\n" +
                    $"3.    Attitude        {sAtt}\n" +
                    $"4.    Health          {sHealth}\n");
                Console.WriteLine($"You have {pointsToSpend} good boy points to spend!");


            Console.ReadKey();


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
   

