using p2_renshu_exe_2_1_2.Models;
namespace p2_renshu_exe_2_1_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            MenuManager menuManager = new MenuManager();

            string menuName;
            int menuPrice;
            int userInput;
            Console.Write("操作の番号を選択してください : ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("メニュー登録を行います。");
                Console.Write("名前を入力 : ");
                menuName = Console.ReadLine();

                Console.Write("金額を入力 : ");
                menuPrice = int.Parse(Console.ReadLine());

                menuManager.MenuAdd(menuName, menuPrice);
            }else if (userInput == 2)
            {
                menuManager.displayMenu();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
