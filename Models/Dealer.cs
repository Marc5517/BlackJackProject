using BlackJackProject.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject.Models
{
    public class Dealer
    {
        private string _name;
        private CardList _cardList;

        public Dealer()
        {

        }

        public Dealer(string name)
        {
            _name = name;
            _cardList = new CardList();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Her skal metoden "Deal" være
        //public static List<Card> Deal()
        //{

        //}
    }
}
