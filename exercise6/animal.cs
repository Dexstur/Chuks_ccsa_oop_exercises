using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine(Name + " has made a sound");
        }


    }
}
