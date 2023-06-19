using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("sound made: bark");
            Console.WriteLine();
        }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Dog() { }

        public Dog(string name, int age, bool gen)
        {
            Name = name;
            Age = age;
            if (gen)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
        }
    }
}
