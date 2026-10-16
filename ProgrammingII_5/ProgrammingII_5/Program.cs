namespace ProgrammingII_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            weight = 55;
            height = 170;
            Console.WriteLine($"BMI = {calcBmi(weight,height)}");
        }

        private static double calcBmi(double weight, double height)
        {
            double bmi = weight / ((height / 100.0) * (height / 100.0));
            return bmi;
        }
    }
}
