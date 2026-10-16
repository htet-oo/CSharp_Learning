using System.Xml;

namespace p2_enshu3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(string Name, int Age)> peopleList = new List<(string Name, int Age)>
            {
                ("山田　太朗",35),
                ("佐藤　花子",28),
                ("田中　健太",42),
                ("鈴木　由美",25),
                ("高橋　浩",38)
            };

            Console.WriteLine("年齢が30歳以上の社員　：　");
            var overThirtyList = peopleList.Where(people => people.Age >= 30).ToList();
            foreach (var person in overThirtyList)
            {
                Console.WriteLine($"{person.Name} ({person.Age}歳)");
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("社員の名前一覧");
            var nameList = peopleList.Select(people => people.Name).ToList();
            foreach(var person in nameList)
            {
                Console.WriteLine($"{person}");
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("名前に「太」　が含まれる社員　：　");
            var nameCheckList = peopleList.Where(people => people.Name.Contains("太")).ToList();
            foreach( var person in nameCheckList)
            {
                Console.WriteLine($"{person.Name} ({person.Age}歳) ");
            }


        }
    }
}
