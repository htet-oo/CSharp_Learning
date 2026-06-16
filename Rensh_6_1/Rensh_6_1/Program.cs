namespace Rensh_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{i + 1}　番目の引数は {args[i]}です。");

            }

        }
    }
}



