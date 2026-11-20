using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1C30JT_HtetOoWaiYan_pbl01
{
    internal class TransactionValidator
    {
        public string checkUserInput(string userInput)
        {
            string result;
            if (!(int.TryParse(userInput, out int userInputInt)))
            {
                result = "入力値が数字以外になっています。";
            }else if (userInputInt < 0)
            {
                result = "入力値がマイナスになっています。";
            }
            else
            {
                result = "ok";
            }
            return result;
        }
    }
}
