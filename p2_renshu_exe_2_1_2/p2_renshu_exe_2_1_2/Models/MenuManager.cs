using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_renshu_exe_2_1_2.Models
{
    internal class MenuManager
    {
        public void MenuAdd(string menuName, int menuPrice)
        {
            using (MenuContext menuContext = new MenuContext())
            {
                Console.WriteLine($"{menuName}:{menuPrice}円を登録します。");
                Menu menu = new Menu();
                menu.MenuName = menuName;
                menu.MenuPrice = menuPrice;

                menuContext.Add(menu);
                menuContext.SaveChanges();
                Console.WriteLine("登録が完了しました。");
            }
        }

        public void displayMenu()
        {
            Console.WriteLine("----- Menuテーブルのレコードを表示します -----");
            using(MenuContext menuContext = new MenuContext())
            {
                Console.WriteLine();
                foreach (Menu menu in menuContext.Menus)
                {
                    Console.WriteLine($"{menu.MenuId}の{menu.MenuName}の金額は{menu.MenuPrice}円です。");
                }
            }
        }


    }
}
