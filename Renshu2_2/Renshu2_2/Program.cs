namespace Renshu2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 整数型の変数aを宣言する
             * 整数型の変数bを宣言する
             * a に 2を代入
             * b に 3を代入
             * a に bを代入
             * a を出力する
             * 
             */
            int a;
            int b;
            a = 2;
            b = 3;
            a = b;
            Console.WriteLine("This is the result of a "+ a);
            Console.WriteLine("こんにちはこちらは a の結果です。"+ a);
            Console.WriteLine("a+b =" + (a+b).ToString());
        }
    }
}
