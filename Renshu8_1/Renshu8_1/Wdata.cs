using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renshu8_1
{
     class Wdata
    {
        public int month;
        public int day;
        public string sky;

        public void output(int month, int day, string sky)
        {
            Console.WriteLine($"{month}月{day}日{sky}");
        }
    }

}
