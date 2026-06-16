namespace Renshu2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            a = a + 10;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine($"{a} is the result of a ");
        }
    }
}
