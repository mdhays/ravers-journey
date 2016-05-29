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

        public void DisplayName()
        {
            Console.WriteLine(PlayerGenre);
        }
    }
}
