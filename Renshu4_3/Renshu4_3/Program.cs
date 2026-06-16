namespace Renshu4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0,i = 0;
            do
            {
                ++i;
                s += i;
            }while (i < 10);
            Console.WriteLine("1 から" + i + "までの和は" + s);
        }
    }
}
