using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai1_1C30JT_HtetOoWaiYan
{
    internal class Book
    {
        public int id;
        public string name;
        public int price;
        private int sum;

        public string GetBookName(int id)
        {
            
            if (id == 1)
            {
                name = "C#入門";
            }else if (id == 2)
            {
                name = "アルゴリズム入門";
            }else if (id == 3)
            {
                name = "オブジェクト指向入門";
            }
            else
            {
                name = "見つかりません";
            }
            this.id = id;
            return name;
        }

        public int GetBookPrice(int id)
        {
            if (id == 1)
            {
                price = 2800;
            }else if (id == 2)
            {
                price = 2600;
            }else if (id == 3)
            {
                price = 3000;
            }
            else
            {
                price = 0;
            }
            this.id = id;
            return price;
        }
        
        public void CalcSum(int price, int quantity)
        {
            if(id > 0)
            {
                int bookPrice = GetBookPrice(id);
                if (bookPrice == price)
                {
                    sum = price * quantity;
                }
                else
                {
                    sum = 0;
                }
            }
            else
            {
                sum = 0;
            }
        }

        public int GetSum()
        {
            return sum;
        }


    }
}
