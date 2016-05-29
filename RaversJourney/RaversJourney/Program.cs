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
                    Trance player = new Trance();
                    Console.WriteLine(s + trance);
                    player.PlayerGenre = "Trance Light Mage";
                    player.Level = 1;
                    player.Health = 12;
                    player.Intelligence = 10;
                    player.Defense = 5;
                    player.Speed = 10;
                    player.DisplayName();
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

            

            Console.ReadLine();



        }
    }
}
