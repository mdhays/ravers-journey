using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaversJourney
{
    class Program
    {

        static void Main(string[] args)
        {
            // classes
            Genres Player = null;
            string trance = " Trance(Light Mage)";
            string dubstep = " Dubstep (Warrior Melee)";
            string trap = " Trap (Heavy Ranger)";
            string dnb = "Drum & Bass(Dark Mage)";
            string house = " House (Thief Melee)";
            string hardcore = " Hardcore (Light Ranger)";

            // assign text to a string since it will be used multiple times.
            string s = "You have selected the class:";

            // for holding selected values
            string userSelection;
            int convertedUserSelection;

            Console.WriteLine("Welcome to Ravers Journey. Please select your path by typing the number that corresponds with the class and pressing ENTER - ");
            Console.WriteLine("");
            Console.WriteLine("[1]" + trance);
            Console.WriteLine("[2]" + dubstep);
            Console.WriteLine("[3]" + trap);
            Console.WriteLine("[4]" + dnb);
            Console.WriteLine("[5]" + house);
            Console.WriteLine("[6]" + hardcore);

            userSelection = Console.ReadLine();

            convertedUserSelection = Int32.Parse(userSelection);

            switch (convertedUserSelection)
            {
                case 1:

                    Player = new Trance();

                    Console.WriteLine(s + trance);

                    Player.DisplayName();

                    break;
                case 2:

                    Console.WriteLine(s + dubstep);
                    break;
                case 3:
                    Console.WriteLine(s + trap);
                    break;

                case 4:
                    Console.WriteLine(s + dnb);
                    break;

                case 5:
                    Console.WriteLine(s + house);
                    break;

                case 6:
                    Console.WriteLine(s + hardcore);
                    break;
            }

            Console.WriteLine(Player);

            Console.WriteLine("What is your stage name, fam?");

            string n = Player.Name;

            n = Console.ReadLine();

            Player.DisplayName();

            Console.WriteLine("");
            Console.WriteLine("Welcome to Ravers Journey " + n + "! " + "If everything looks good, press Enter...");

            Console.ReadLine();

            Console.WriteLine("In an alternate universe, the year is 2100. Mankind has been plunged into chaos as faschist DJs have taken over the world. The DJ Mag Top 100 now determines an indivdual's social status. In order to claim a member's spot, you must defeat them in a battle of beats.");
            Console.WriteLine("Democracy is dead, votes used to be cast to show who was the best DJ. Now, one hero will attempt to become number one on a useless countdown to free mankind from the chaos of the wretched Top 100, and restore democracy to the world.");

            Console.ReadLine();



        }
    }
}
