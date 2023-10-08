using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTradingCardsGame_2
{
    internal class MonsterCard : Card
    {
        public MonsterCard()
        {
            CardType = "MonsterCard";
        }

        public override void TestMethod()
        {
            Console.WriteLine("Print Class-Child MonsterCard");
            TestParentClass();
        }
    }
}
