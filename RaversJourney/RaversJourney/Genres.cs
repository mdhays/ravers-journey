using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaversJourney
{
    abstract class Genres : IDisplayName
    {
        public string PlayerGenre { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public virtual void DisplayName()
        {
            Console.WriteLine(PlayerGenre);
        }
    }
}
