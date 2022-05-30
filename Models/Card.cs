using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject.Models
{
    public class Card
    {
        private string _name;
        private int _points;
        private string _suit;

        public Card()
        {

        }

        public Card(string name, int points, string suit)
        {
            _name = name;
            _points = points;
            _suit = suit;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        /// <summary>
        /// This returns a string that shows a Card object's data.
        /// </summary>
        /// <returns>The name, points and suit of a card.</returns>
        public override string ToString()
        {
            return $"{nameof(Name)}: {_name}, {nameof(Points)}: {_points}, {nameof(Suit)}: {_suit}";
        }
    }
}
