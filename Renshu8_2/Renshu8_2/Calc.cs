using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renshu8_2
{
    internal class Calc
    {
        public int add(int numberOne,int numberTwo)
        {
            return(numberOne + numberTwo);
        }

        public int minus(int numberOne, int numberTwo)
        {
            return (numberOne - numberTwo);
        }

        public int multiply(int numberOne, int numberTwo)
        {
            return (numberOne * numberTwo);
        }

        public int divided(int numberOne, int numberTwo)
        {
            return (numberOne / numberTwo);
        }

        public int modulus(int numberOne, int numberTwo)
        {
            return (numberOne % numberTwo);
        }





        public void disp(int number)
        {
            Console.WriteLine("引数の値は" + number);
            return;
        }
    }
}
