using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKinshu
{
    internal class Calc
    {
        public int money;
        public int cnt;

        public int forTenThousand(int money)
        {
            cnt = money / 10000;
            this.money = money % 10000;
            return cnt;
        }

        public int forFiveThousand()
        {
            cnt = this.money / 5000;
            this.money = this.money % 5000;
            return cnt;
        }

        public int forOneThousand()
        {
            cnt = this.money / 1000;
            this.money = this.money % 1000;
            return cnt;
        }

        public int forFiveHundred()
        {
            cnt = this.money / 500;
            this.money = this.money % 500;
            return cnt;
        }

        public int forOneHundred()
        {
            cnt = this.money / 100;
            this.money = this.money % 100;
            return cnt;
        }

        public int forFifty()
        {
            cnt = this.money / 50;
            this.money = this.money % 50;
            return cnt;
        }

        public int forTen()
        {
            cnt = this.money / 10;
            this.money = this.money % 10;
            return cnt;
        }

        public int forFive()
        {
            cnt = this.money / 5;
            this.money = this.money % 5;
            return cnt;
        }

        public int forOne()
        {
            cnt = this.money / 1;
            this.money = this.money % 1;
            return cnt;
        }

        public int changes(int pay, int sum)
        {
            return pay - sum;
        }
    }
}
