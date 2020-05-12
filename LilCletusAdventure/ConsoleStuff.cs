using System;
using System.Collections.Generic;
using System.Text;

namespace LilCletusAdventure
{
    class ConsoleStuff
    {
        public static void Break()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool YesOrNo(string question) 
        {
            Console.WriteLine(question);
            Console.WriteLine(" (Y/N?)");
            string response = Console.ReadLine()
                                     .ToUpper();


            switch(response)
            {
                case "Y":
                    return true;

                case "N":
                    return false;
                default:
                    Console.WriteLine("Answer Y or N to continue");
                    YesOrNo(question);
                    break;
            }
            return false;
        }
    }
}
