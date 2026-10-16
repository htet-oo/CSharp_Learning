namespace ProgrammingII_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shincho;
            double taiju;

            shincho = 170;
            taiju = 55;

            Console.WriteLine("BMI = {0}", taiju / ((shincho / 100.0) * (shincho / 100.0)));
        }
    }
}
