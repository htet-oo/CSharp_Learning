namespace Renshu8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount("Abe",100000);
            BankAccount b = new BankAccount("Baba", 20000);

            a.Withdraw(120000);
            a.Deposit(10000);
            b.Withdraw(5000);
            a.showInfo();
            b.showInfo();
        }
    }
}
