using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renshu
{
    class Book
    {
        string bookName;
        string bookPrice;
        private int sum;
        //public Book(string bookName, string bookPrice)
        //{
        //    this.bookName = bookName;
        //    this.bookPrice = bookPrice;
        //}

        public string GetBookName(int bookId)
        {
            switch (bookId)
            {
                case 1:
                    return "C#入門";
                    break;
                case 2:
                    return "アルゴリズム入門";
                    break;
                case 3:
                    return "オブジェクト指向入門";
                    break;
                case 4:
                    return "見つかりません";
                    break;
                default:
                    return "error";
            }
        }
        public int GetBookPrice(int bookId)
        {
            switch (bookId)
            {
                case 1:
                    return 2800;
                    break;
                case 2:
                    return 2600;
                    break;
                case 3:
                    return 3000;
                    break;
                default:
                    return 0;
            }
        }

        private void CalcSum(int price, int count)
        {
            sum = price * count;
        }
        public int GetSum(int price, int count)
        {
            CalcSum(price, count);
            return sum;
        }


    }
}
