using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_renshu2
{
    internal class Character
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Character(string name,int age)
        {
            _name = name;
            _age = age;
        }

        public void attach()
        {
            Console.WriteLine($"I am {Name} attacking.");
        }

        public void defend()
        {
            Console.WriteLine($"I am {Name} defending");
        }
    }
}
