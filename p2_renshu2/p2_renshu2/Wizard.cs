using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_renshu2
{
    internal class Wizard : Character
    {
        public Wizard(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;    
        }

        public void megic()
        {
            Console.WriteLine($"I am {Name} using power.");
        }
    }
}
