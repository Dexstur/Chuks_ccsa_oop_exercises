using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class TomCat : Animal
    {
        public TomCat(string name, int age, bool gen)
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
        public TomCat() { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("sound made: squeal");
            Console.WriteLine();
        }
    }
}
