using System.Security.Cryptography.X509Certificates;

namespace p2_renshu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Htet Oo Wai Yan";
            student.Score = 100;
            Console.WriteLine($"{student.Name}さんの点数は{student.Score}点です。");

            student.Score = 0;
            Console.WriteLine($"{student.Name}さんの点数は{student.Score}点です。");

            Wizard wizard = new Wizard("Htet Oo", 23);
            wizard.attach();
            wizard.defend();
            wizard.megic();
        }
    }
}
