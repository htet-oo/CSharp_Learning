using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renshu9_3
{
    internal class HappeningButtonLogic
    {
        private Random _random;
        private string[] _messages = { "ボタンを押して下さい。","爆発", "お小遣いゲット","エラーが発生しませんでした。","レベルアップ!"};
        public int ClickCount { get; private set; }
        public string CurrentMessage { get; private set; }
        public int LuckyLevel{get;private set;}
        public HappeningButtonLogic()
        {
            _random = new Random();
            ClickCount = 0;
            CurrentMessage = _messages[0];
            LuckyLevel = 3;
        }

        public void TriggerHappening()
        {
            ClickCount++;
            CurrentMessage = _messages[_random.Next(_messages.Length)];
            LuckyLevel++;
        }

    }
}
