using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renshu8_5
{
    internal class BankAccount
    {
        private string name;
        private float balance;
        public BankAccount(string name, float balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"{this.name} の口座に{amount}円預金しました。");
        }

        public void Withdraw(int amount)
        {
            if (balance - amount < 0)
            {
                Console.WriteLine("残高不足");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"{this.name} の口座に{amount}円出しました。");
            }
        }

        public void showInfo()
        {
            Console.WriteLine($"{name}, 残高 : {balance}");
        }
    }
}
