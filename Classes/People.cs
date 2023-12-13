using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Classes
{
    public class People
    {
        private string Name { get; set; }
        private int Age { get; set; }
        public People(string name, int age)
        {
            Name = name;

            Age = age;
        }
    }
}
