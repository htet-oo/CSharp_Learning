using p2_renshu_exe_2_1_1.Models;
namespace p2_renshu_exe_2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuName;
            int menuPrice;
            Console.WriteLine("メニュー登録を行います。");
            Console.Write("名前を入力 : ");
            menuName = Console.ReadLine();

            Console.Write("金額を入力 : ");
            menuPrice = int.Parse(Console.ReadLine());

            using (MenuContext context = new MenuContext())
            {
                Console.WriteLine($"{menuName}:{menuPrice}円を登録します。");
                Menu menu = new Menu();
                menu.MenuName = menuName;
                menu.MenuPrice = menuPrice;

                context.Add(menu);
                context.SaveChanges();
                Console.WriteLine("登録が完了しました。");
            }

            using (MenuContext context = new MenuContext())
            {
                foreach (Menu menu in context.Menus)
                {
                    Console.WriteLine($"Menu Id : {menu.MenuId} MenuName : {menu.MenuName} MenuPrice : {menu.MenuPrice}円");
                }
            }


           
        }
    }
}
