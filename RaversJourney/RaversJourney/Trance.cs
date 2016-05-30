using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaversJourney
{
    class Trance : Genres
    { 
        Random levelUpRNG = new Random();
        public int Intelligence { get; set; }


        public override void DisplayName()
        {
            PlayerGenre = "Trance Light Mage";
            Level = 1;
            Health = 12;
            Intelligence = 10;
            Defense = 5;
            Speed = 10;


            Console.WriteLine("");
            Console.WriteLine("Genre: " + PlayerGenre);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Intelligence: " + Intelligence);
            Console.WriteLine("Defense: " + Defense);
            Console.WriteLine("Speed: " + Speed);
        }
    }
}
