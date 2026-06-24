namespace Renshu9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HappeningButtonLogic hbl = new HappeningButtonLogic();
            hbl.TriggerHappening();
            string message = hbl.CurrentMessage;
            Console.WriteLine(message);
        }
    }
}
