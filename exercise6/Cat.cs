using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class Cat : Animal
    {
        public Cat() { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("sound made: meow");
            Console.WriteLine();
        }
    }
}
