namespace ConsoleKinshu_1C30JT_HTETOOWAIYAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pay, dep;
            Console.Write("代金 : ");
            pay = int.Parse(Console.ReadLine());
            Console.Write("預り金額 : ");
            dep = int.Parse(Console.ReadLine());

            Payment payment = new Payment(pay, dep);

            Console.WriteLine("お釣り : " + payment.GetChangeAmount());
            payment.ShowChangeBreakDown();

        }
    }
}
