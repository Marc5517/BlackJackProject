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

        /// <summary>
        /// Shows the card's name and suit
        /// </summary>
        /// <param name="name"></param>
        /// <param name="suit"></param>
        public void ShowCards(string name, string suit)
        {
            Console.WriteLine("Dealer: " + name + " of " + suit);
        }

        /// <summary>
        /// If the card the dealer gives out turns out to be a joker, then player's total point become 21 automatically.
        /// If not, then it just shows the card.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="suit"></param>
        /// <param name="player"></param>
        public void PickingJoker(string name, string suit, Player player)
        {
            if (name.Equals("Joker"))
            {
                Console.WriteLine("Dealer: You got a Joker!");
                player.TotalPoints = 21;
            }
            else
            {
                ShowCards(name, suit);
                //Console.WriteLine("Dealer: " + name + " of " + suit);
            }
        }

        /// <summary>
        /// If the card turns out to be an Ace and the player's total points are lower than 11,
        /// the ace is worth 11 points.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="player"></param>
        public void PickingAce(string name, Player player)
        {
            if (name.Equals("Ace") && player.TotalPoints < 11)
            {
                player.TotalPoints = player.TotalPoints + 10;
                Console.WriteLine("Dealer: Since your total points are lower than 11, the ace is worth 11 points");
            }
        }
    }
}
