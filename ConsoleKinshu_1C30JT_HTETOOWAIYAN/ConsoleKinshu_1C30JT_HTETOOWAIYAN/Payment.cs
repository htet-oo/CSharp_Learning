using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKinshu_1C30JT_HTETOOWAIYAN
{
    internal class Payment
    {
        private int TotalPrice;
        private int Deposit;
        private int money;

        public Payment(int totalPrice, int deposit)
        {
            TotalPrice = totalPrice;
            Deposit = deposit;
        }

        public int GetChangeAmount()
        {
            money = TotalPrice - Deposit;
            return money;
        }

        public void ShowChangeBreakDown()
        {
            Console.WriteLine("万円札　　:　" + money / 10000);
            money = money % 10000;

            Console.WriteLine("五千円札　:　" + (money / 5000));
            money = money % 5000;

            Console.WriteLine("千円札　  :　" + money / 1000);
            money = money % 1000;

            Console.WriteLine("五百円玉　:　" + money / 500);
            money = money % 500;

            Console.WriteLine("百円玉　  :　" + money / 100);
            money = money % 100;

            Console.WriteLine("五十円玉　:　" + money / 50);
            money = money % 50;

            Console.WriteLine("五十円玉　:　" + money / 10);
            money = money % 10;

            Console.WriteLine("五十円玉　:　" + money / 5);
            money = money % 5;

            Console.WriteLine("五十円玉　:　" + money / 1);
            money = money % 1;

        }
    }
}
