using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaversJourney
{
    class Text
    {
        Genres Player = null;
        private string trance = " Trance(Light Mage)";
        private string dubstep = " Dubstep (Warrior Melee)";
        private string trap = " Trap (Heavy Ranger)";
        private string dnb = "Drum & Bass(Dark Mage)";
        private string house = " House (Thief Melee)";
        private string hardcore = " Hardcore (Light Ranger)";
        private string s = "You have selected the class:";
        private string userSelection;
        private string name;
        private int convertedUserSelection;

        private void Space()
        {
            Console.WriteLine("");
        }

        internal void Intro()
        {
            Console.WriteLine("Welcome to Ravers Journey. Please select your path by typing the number that corresponds with the class and pressing ENTER - ");
            Console.WriteLine("");
            Console.WriteLine("[1]" + trance);
            Console.WriteLine("[2]" + dubstep);
            Console.WriteLine("[3]" + trap);
            Console.WriteLine("[4]" + dnb);
            Console.WriteLine("[5]" + house);
            Console.WriteLine("[6]" + hardcore);
            Space();
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

            Console.WriteLine("What is your stage name?");

            string n = Player.Name;
            name = n;
            name = Console.ReadLine();

            Player.DisplayName();

            Space();
            Console.WriteLine("Welcome to Ravers Journey " + name + "! " + "If everything looks good, press Enter...");
            Console.ReadLine();
            Console.WriteLine("In an alternate universe, the year is 2047. Mankind has been plunged into chaos as faschist DJs controlled by the Illuminate (also known as the \"Dank Ones\") have taken over the world. The DJ Mag Top 100 now determines an indivdual's social status. In order to claim a member's spot, you must defeat them in a battle of beats.");
            Console.WriteLine("Democracy is dead, votes used to be cast to show who was the best DJ. Now, one hero will attempt to become number one on a useless countdown to free mankind from the chaos of the wretched Top 10 DJs, and restore freedom to the world.");
            Console.ReadLine();
            Space();
        }

        internal void Chapter1()
        {
            Console.WriteLine("Our story begins on the Spanish island of Ibiza. " + name + " has just arrived to play a show at one of the most exclusive nightclubs in the world. However, his true purpose for coming to the island is to challenge Number 10 DJ, Dillon Francis, and begin to gather the recognition needed to challenge others that stand in his way. Confident and without fear, Dillon accepted the challenge, eager to show his loyalty and power to the Dank Ones.");
            Space();
            Console.ReadLine();
        }
    }
}
