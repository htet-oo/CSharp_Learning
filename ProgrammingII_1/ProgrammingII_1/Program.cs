namespace ProgrammingII_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = 3;
            int iValue = 10;
            int work;


            Console.WriteLine($"data : {data}");
            Console.WriteLine($"iValue : {iValue}");

            work = iValue;
            iValue = data;
            data = work;

            Console.WriteLine($"data : {data}");
            Console.WriteLine($"iValue : {iValue}");
        }
    }
}
