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
            Console.WriteLine("");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Genre: " + PlayerGenre);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Intelligence: " + Intelligence);
            Console.WriteLine("Defense: " + Defense);
            Console.WriteLine("Speed: " + Speed);
        }
    }
}
