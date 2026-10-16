using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_renshu2
{
    internal class Student
    {
        private string _name;
        private int _score;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Score
        {
            get { return _score; }
            set
            {
                if(value >= 0  && value <= 100)
                {
                    _score = value;
                }
                else
                {
                    _score = 0;
                }
            }
        }
    }
}
