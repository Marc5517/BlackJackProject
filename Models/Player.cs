using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject.Models
{
    public class Player
    {
        private string _name;
        private int _totalPoints;
        
        public Player()
        {

        }

        public Player(string name, int totalPoints)
        {
            _name = name;
            _totalPoints = totalPoints;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int TotalPoints
        {
            get { return _totalPoints; }
            set
            {
                _totalPoints = value;
            }
        }

        /// <summary>
        /// This method uses the points from another variable from a class 
        /// to calculate the total points of the player's points.
        /// </summary>
        /// <param name="card"></param>
        public void ReceivePoints(Card card)
        {
            TotalPoints = TotalPoints + card.Points;
        }
    }
}
