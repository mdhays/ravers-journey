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
            Text Script = new Text();

            Script.Intro();
            Console.ReadLine();
            Script.Chapter1();
        }
    }
}
