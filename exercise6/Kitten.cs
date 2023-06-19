using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class Kitten : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("sound made: purr");
            Console.WriteLine();
        }
    }
}
