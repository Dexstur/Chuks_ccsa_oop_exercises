using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public int CompareTo(Student other)
        {
            return Mark.CompareTo(other.Mark);
        }
    }
}
