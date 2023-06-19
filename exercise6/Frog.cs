using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class Frog : Animal
    {
        public Frog() { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("sound made: croak");
            Console.WriteLine();

        }
    }
}
