namespace Renshu8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int n;
            n= calc.add(1,1);
            calc.disp(n);
            
            n = calc.minus(1, 1);
            calc.disp(n);

            n = calc.multiply(1, 1);
            calc.disp(n);

            n = calc.divided(1, 1);
            calc.disp(n);

            n = calc.modulus(1, 1);
            calc.disp(n);

        }
    }
}
