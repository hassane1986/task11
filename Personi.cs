using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public struct Personi
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Personi(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
