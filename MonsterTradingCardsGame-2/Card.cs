using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTradingCardsGame_2
{
    internal class Card
    {
        private string _cardtype;
        private string _elementType;

        public string CardType
        {
            get { return _cardtype; }
            set { _cardtype = value; }
        }

        public string ElementType
        {
            get { return _elementType; }
            set { _elementType = value; }
        }


        public void TestParentClass()
        {
            Console.WriteLine("Parent Class Function call");
        }

        public virtual void TestMethod()
        {
            Console.WriteLine("Print Class-Parent Card");
        }
    }
}
