using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LilCletusAdventure
{
    class StoryLine
    {
        public static LilCletus CharacterCreator()
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

                        Console.Clear();

                        if (pointsToAdd >= 10)
                        {
                            Console.WriteLine("WOW! That's a thicc ass boi!");
                        }
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


            Console.WriteLine("Here are your stats:\n\n" +
                $"1.    Mass:           {sMass} \n" +
                $"2.    Intellegence    {sIntel}\n" +
                $"3.    Attitude        {sAtt}\n" +
                $"4.    Health          {sHealth}\n");
            Console.WriteLine($"You have {pointsToSpend} good boy points to spend!");



            while (true)
            {
                Console.WriteLine("How smart are you");
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
                    Console.WriteLine("You don't even know what numbers are. You should probably add points here.");
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
                Console.WriteLine($"How sassy are ya?");
                string sAnswer = Console.ReadLine();

                int pointsToAdd = 0;

                bool isNumber = int.TryParse(sAnswer, out pointsToAdd);

                if (isNumber)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        attitude += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sAtt = attitude.ToString();
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
                Console.WriteLine($"How healthy are ya?");
                string sAnswer = Console.ReadLine();

                int pointsToAdd = 0;

                bool isNumber = int.TryParse(sAnswer, out pointsToAdd);

                if (isNumber)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        health += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sHealth = health.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"It's unhealthy to lie about good boy points. {pointsToSpend} remain");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number. It's very unhealthy to do that.");
                    continue;
                }



            }

            Console.Clear();


            Console.WriteLine("Atta boy lil Cleet. Get yer Cleetfeet ready for adventure.");


            LilCletus lilCleet = new LilCletus(mass, intellegence, attitude, health);


            Console.WriteLine($"Here's your final mass: {lilCleet.Mass.ToString()} " +
                $"\nHere's your final intellegence: {lilCleet.Intelegence.ToString()}" +
                $"\nHere's your final Attitude: {lilCleet.Attitude.ToString()}" +
                $"\nHere's your final Health: {lilCleet.Health.ToString()}");


            Console.WriteLine("Are you happy with these choices? (y/n)");
            string doesntMatterAnswer = Console.ReadLine();
            doesntMatterAnswer = doesntMatterAnswer.ToLower();
            if (doesntMatterAnswer == "y")
            {
                Console.WriteLine("You have made an appropriate choice.");
            }
            else if (doesntMatterAnswer == "n")
            {
                CharacterCreator();
                Console.WriteLine("You only have one chance in life. This is no different. Time to party.");
            }
            else
            {
                Console.WriteLine("y/n means yes or no. You forfeit your chance to re-do. Time to party");
            }

            Console.ReadKey();
            
            return lilCleet;
        }

        public static LilCletus GetWoke(LilCletus lil)
        {
            string playerChoice;

            Buff maskBuff = new Buff("Health", 2);
            Buff shadesBuff = new Buff("Attitude", 1);


// This is how you inialize a new list and add the new item at the same time. 
            List<Buff> maskBuffs =new List<Buff>() { maskBuff };
            List<Buff> shadesBuffs = new List<Buff>() { shadesBuff };

// Adding item descrptions outside of the list to make it more readable
            string maskDes = "A small square piece of fabric. It smells like old whiskey, and gives minor protection from \n" +
                "the toxic air outside.";
            string shadesDes = "Awesome pre-rag sunglasses. The apocolaypse is no excuse to not look super badass.";

// Adds items to item constructor and adds the parameters to them
            Item mask = new Item("Face mask", maskDes, false, maskBuffs);
            Item shades = new Item("Sick Shades", shadesDes, false, shadesBuffs);


// checks if actions are already completed
            bool didLookUnderNews = false;
            bool didLookInMirror = false;
            bool didOpenChest = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("The morning has not been kind. You lack purpose and direction." +
                    "\nYou got shit to do today, and going outside is nessesary. " +
                    "\nYou need your apocolypse shades and a mask to protect yourself." +
                    "\nYou survey the room. It's a dump. You see a desk with a damp newspaper on it " +
                    "\nThere is a mirror propped against the wall " +
                    "\nA large treause chest with the word 'treasure' hastily scribble in crayon sits at the end of your bed " +
                    "\nI refuse to face the outside world lookin like a simp and also probably dying" +
                    "\nWhat would you like to do?");
                if(!didLookUnderNews)
                {
                    Console.WriteLine("\n1.  Read newspaper");
                }
                if(!didLookInMirror)
                {
                    Console.WriteLine("\n2.  Look in mirror");
                }
                if(!didOpenChest)
                {
                    Console.WriteLine("\n3.  Check 'treasure' chest");
                }
                Console.WriteLine("\n4.   Go outside" );

                Console.WriteLine("Enter the number of the choice you'd like to make");

                playerChoice = Console.ReadLine();

                switch (playerChoice)
                {
                    case "1":
                        if (didLookUnderNews)
                        {
                            Console.WriteLine("The soggy newspaper has desintigrated; there's nothing left over there except\n" +
                                " a pile of goop. Ragnarok is old news anyways.");
                        }
                        else
                        {
                            Console.WriteLine("You grab the paper. It falls apart in your hands into a soggy pile \n" +
                                "next to your sunglasses. Oh hey! There they are.");
                            lil.ItemBag.Add(shades);
                            didLookUnderNews = true;
                        }
                        break;
                    case "2":
                        if (didLookInMirror)
                        {
                            Console.WriteLine("You literally cannot stand to look at yourself anymore today at the risk \n" +
                                "of arousal.");
                        }
                        else
                        {
                            Console.WriteLine("You look in the mirror. You notice a facemask on top of your noodle. \n" +
                                "You pull it over your face in proper PPE fashion");
                            lil.ItemBag.Add(mask);
                            didLookInMirror = true;
                        }
                        break;
                    case "3":
                        if (didOpenChest)
                        {
                            Console.WriteLine("You already touched what's inside with your eyes enough today");
                        }
                        else
                        {
                            Console.WriteLine("You open the chest. Inside is the most valuable object in the entire world \n" +
                                "to the only person in the world that matters. You.");
                            didOpenChest = true;
                        }
                        break;
                    case "4":
                        bool response = true;
                        if(!didLookUnderNews && !didLookInMirror)
                        {
                            response = ConsoleStuff.YesOrNo("Leaving without double checking your rad levels is dangerous." +
                                "\n Odin's wrath will surely reach you in this state. You sure you want to leave?");
                        }
                        if (!didLookUnderNews)
                        {
                            response = ConsoleStuff.YesOrNo("You're about to leave without looking fresh af. Are you sure?");
                        }
                        else if (!didLookInMirror)
                        {
                            response = ConsoleStuff.YesOrNo("You can't leave without a self occular pat down. Are you sure?");
                        }
                        else
                        {
                            Console.WriteLine("Your swag is sufficient; Odin will be pleased. Time to head outside.");
                            break;
                        }
                        if (response)
                        {
                            Console.WriteLine("The skies darken and a rumbling can be heard. You see a shadowy figure descend from the skies." +
                                "\nIt's lord Odin on his mighty steed, Slippy. His voice resonates inside your skull 'LEAVING " +
                                "\nWITHOUT PROPER PROTECTION IS AGAINST ALL NORSE LAW'. He immediately smites you with the " +
                                "\npower and pain of a thousand deaths. Your final thoughts of are how hillarious Odin's real" +
                                "\nlife horse in Norse mythology is named 'Slippy'");
                        }

                        break;
                    default:
                        Console.WriteLine("Enter a number between 1-4 to continue.");
                        break;
                        }

                if (didLookInMirror && didLookUnderNews)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You're swag levels are that of those whom reside on Valhalla. You confidently" +
                        "\nexit your dump of a home and out into the scorched landscape.");
                    ConsoleStuff.Break();
                    continue;
                }

            }

            return lil;
        }

    }

}
