using BlackJackProject.Lists;
using BlackJackProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    public class Program
    {
        public static void Main()
        {
            Card card = new Card("Jack", 10, "Hearts");
            Card card2 = new Card("Four", 4, "Spades");
            Card card3 = new Card("Seven", 7, "Diamonds");

            Player player = new Player("Marc", 0);
            Player playerD = new Player("Dealer", 0);

            var random = new Random();

            var list = CardList.cards;
            //var list = new List<Card> 
            //{
            //    new Card("Ace", 1, "Hearts"),
            //    new Card("Ace", 1, "Spades"),
            //    new Card("Ace", 1, "Diamonds"),
            //    new Card("Ace", 1, "Clovers"),
            //    new Card("Two", 2, "Hearts"),
            //    new Card("Two", 2, "Spades"),
            //    new Card("Two", 2, "Diamonds"),
            //    new Card("Two", 2, "Clovers"),
            //    new Card("Three", 3, "Hearts"),
            //    new Card("Three", 3, "Spades"),
            //    new Card("Three", 3, "Diamonds"),
            //    new Card("Three", 3, "Clovers"),
            //    new Card("Four", 4, "Hearts"),
            //    new Card("Four", 4, "Spades"),
            //    new Card("Four", 4, "Diamonds"),
            //    new Card("Four", 4, "Clovers"),
            //    new Card("Five", 5, "Hearts"),
            //    new Card("Five", 5, "Spades"),
            //    new Card("Five", 5, "Diamonds"),
            //    new Card("Five", 5, "Clovers"),
            //    new Card("Six", 6, "Hearts"),
            //    new Card("Six", 6, "Spades"),
            //    new Card("Six", 6, "Diamonds"),
            //    new Card("Six", 6, "Clovers"),
            //    new Card("Seven", 7, "Hearts"),
            //    new Card("Seven", 7, "Spades"),
            //    new Card("Seven", 7, "Diamonds"),
            //    new Card("Seven", 7, "Clovers"),
            //    new Card("Eight", 8, "Hearts"),
            //    new Card("Eight", 8, "Spades"),
            //    new Card("Eight", 8, "Diamonds"),
            //    new Card("Eight", 8, "Clovers"),
            //    new Card("Nine", 9, "Hearts"),
            //    new Card("Nine", 9, "Spades"),
            //    new Card("Nine", 9, "Diamonds"),
            //    new Card("Nine", 9, "Clovers"),
            //    new Card("Ten", 10, "Hearts"),
            //    new Card("Ten", 10, "Spades"),
            //    new Card("Ten", 10, "Diamonds"),
            //    new Card("Ten", 10, "Clovers"),
            //    new Card("Jack", 10, "Hearts"),
            //    new Card("Jack", 10, "Spades"),
            //    new Card("Jack", 10, "Diamonds"),
            //    new Card("Jack", 10, "Clovers"),
            //    new Card("Queen", 10, "Hearts"),
            //    new Card("Queen", 10, "Spades"),
            //    new Card("Queen", 10, "Diamonds"),
            //    new Card("Queen", 10, "Clovers"),
            //    new Card("King", 10, "Hearts"),
            //    new Card("King", 10, "Spades"),
            //    new Card("King", 10, "Diamonds"),
            //    new Card("King", 10, "Clovers"),
            //    new Card("Joker", 0, "")
            //};

            //Version 1: Simple from start
            //Console.WriteLine("Dealer: " + card.Name + " of " + card.Suit);
            //Console.WriteLine("Dealer: That's " + card.Points);

            //Console.ReadKey();

            //Console.WriteLine("Dealer: " + card2.Name + " of " + card2.Suit);
            //Console.WriteLine("Dealer: That's " + (card.Points + card2.Points));

            //Console.ReadKey();

            //Console.WriteLine("Dealer: " + card3.Name + " of " + card3.Suit);
            //Console.WriteLine("Dealer: That's " + (card.Points + card2.Points + card3.Points));
            //

            //Version 2: Next step with a player and a method
            //Console.WriteLine("Player " + player.Name + " has " + player.TotalPoints + " points.");

            //Console.ReadKey();

            //Console.WriteLine("Dealer: " + card.Name + " of " + card.Suit);
            //player.ReceivePoints(card);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //Console.ReadKey();

            //Console.WriteLine("Dealer: " + card2.Name + " of " + card2.Suit);
            //player.ReceivePoints(card2);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //Console.ReadKey();

            //Console.WriteLine("Dealer: " + card3.Name + " of " + card3.Suit);
            //player.ReceivePoints(card3);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);
            //

            //Version 3: Next Step with if-statement and specific ReadKey
            //Console.WriteLine("Player " + player.Name + " has " + player.TotalPoints + " points.");

            //Console.Write("\nPress 'H' to Hit you a new card...");
            //while (Console.ReadKey(true).Key != ConsoleKey.H)
            //{
            //}

            //Console.WriteLine("Dealer: " + card.Name + " of " + card.Suit);
            //player.ReceivePoints(card);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //Console.Write("\nPress 'H' to Hit you a new card");
            //while (Console.ReadKey(true).Key != ConsoleKey.H)
            //{
            //}

            //Console.WriteLine("Dealer: " + card2.Name + " of " + card2.Suit);
            //player.ReceivePoints(card2);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //Console.Write("\nPress 'H' to Hit you a new card");
            //while (Console.ReadKey(true).Key != ConsoleKey.H)
            //{
            //}

            //Console.WriteLine("Dealer: " + card3.Name + " of " + card3.Suit);
            //player.ReceivePoints(card3);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //if (player.TotalPoints == 21)
            //{
            //    Console.WriteLine(player.Name + " has won!");
            //}
            //else
            //{
            //    Console.WriteLine(player.Name + " has lost... since his total points are " + player.TotalPoints);
            //}
            //

            //Version 4: Next step with list, random and it lasts 3 to 5 rounds
            //Console.WriteLine("Player " + player.Name + " has " + player.TotalPoints + " points.");

            //Console.Write("\nPress 'H' to Hit you a new card...");
            //while (Console.ReadKey(true).Key != ConsoleKey.H)
            //{
            //}

            //int index = random.Next(list.Count);

            //Console.WriteLine("Dealer: " + list[index].Name + " of " + list[index].Suit);
            //player.ReceivePoints(list[index]);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //Console.Write("\nPress 'H' to Hit you a new card");
            //while (Console.ReadKey(true).Key != ConsoleKey.H)
            //{
            //}

            //int index2 = random.Next(list.Count);

            //Console.WriteLine("Dealer: " + list[index2].Name + " of " + list[index2].Suit);
            //player.ReceivePoints(list[index2]);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //Console.Write("\nPress 'H' to Hit you a new card");
            //while (Console.ReadKey(true).Key != ConsoleKey.H)
            //{
            //}

            //int index3 = random.Next(list.Count);

            //Console.WriteLine("Dealer: " + list[index3].Name + " of " + list[index3].Suit);
            //player.ReceivePoints(list[index3]);
            //Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //if (player.TotalPoints == 21)
            //{
            //    Console.WriteLine(player.Name + " has won!");
            //}
            //else if (player.TotalPoints >= 21)
            //{
            //    Console.WriteLine(player.Name + " has lost... since his total points are " + player.TotalPoints);
            //}
            //else
            //{
            //    Console.Write("\nPress 'H' to Hit you a new card");
            //    while (Console.ReadKey(true).Key != ConsoleKey.H)
            //    {
            //    }

            //    int index4 = random.Next(list.Count);

            //    Console.WriteLine("Dealer: " + list[index4].Name + " of " + list[index4].Suit);
            //    player.ReceivePoints(list[index4]);
            //    Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //    if (player.TotalPoints == 21)
            //    {
            //        Console.WriteLine(player.Name + " has won!");
            //    }
            //    else if (player.TotalPoints >= 21)
            //    {
            //        Console.WriteLine(player.Name + " has lost... since his total points are " + player.TotalPoints);
            //    }
            //    else
            //    {
            //        Console.Write("\nPress 'H' to Hit you a new card");
            //        while (Console.ReadKey(true).Key != ConsoleKey.H)
            //        {
            //        }

            //        int index5 = random.Next(list.Count);

            //        Console.WriteLine("Dealer: " + list[index5].Name + " of " + list[index5].Suit);
            //        player.ReceivePoints(list[index5]);
            //        Console.WriteLine("Dealer: That's " + player.TotalPoints);

            //        if (player.TotalPoints == 21)
            //        {
            //            Console.WriteLine(player.Name + " has won!");
            //        }
            //        else
            //        {
            //            Console.WriteLine(player.Name + " has lost... since his total points are " + player.TotalPoints);
            //        }
            //    }
            //}
            //

            //Version 5: Next step - Now with some while-loops, rules for some cards and the obtion to stand and play again
            Console.WriteLine("Press 'Y' to start, press any other key and you exit program");
            
            ///The game/loop begins and restarts from here when a player clicks at 'Y'.
            while (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Console.WriteLine("Player " + player.Name + " has " + player.TotalPoints + " points.");
                Console.Write("\nPress 'H' to Hit you a new card or 'S' to stand.\n");

                ///This loop only begins when a player's total points are at 0 and when they click at 'H'.
                while (player.TotalPoints < 21)
                {
                    int index = random.Next(list.Count);

                    ///If a player presses anything other than 'H', the player stands.
                    while (Console.ReadKey(true).Key != ConsoleKey.H)
                    {
                        ///The loop stops once the dealer has reached the limit of 17 points.
                        while (playerD.TotalPoints < 17)
                        {
                            Console.WriteLine("\nPlayer: Stand.");
                            
                            int index2 = random.Next(list.Count);
                            Console.WriteLine("Dealer: " + list[index2].Name + " of " + list[index2].Suit);

                            playerD.ReceivePoints(list[index2]);
                            Console.WriteLine("Dealer: That's " + playerD.TotalPoints);
                        }
                    }

                    Console.WriteLine("\nPlayer: Hit me");

                    ///If the player gets a joker, the player's points become 21.
                    if (list[index].Name.Equals("Joker"))
                    {
                        Console.WriteLine("Dealer: You got a Joker!");
                        player.TotalPoints = 21;
                    }
                    else
                    {
                        Console.WriteLine("Dealer: " + list[index].Name + " of " + list[index].Suit);
                    }

                    ///If the player gets an Ace, then they gain 10 extra points, unless they have more than 10 total points.
                    if (list[index].Name.Equals("Ace") && player.TotalPoints < 11)
                    {
                        player.TotalPoints = player.TotalPoints + 10;
                        Console.WriteLine("Dealer: Since your total points are lower than 11, that gives " + (list[index].Points + 10));
                    }

                    player.ReceivePoints(list[index]);
                    Console.WriteLine("Dealer: That's " + player.TotalPoints);
                }

                if (player.TotalPoints == 21)
                {
                    Console.WriteLine(player.Name + " has won!");
                }
                else
                {
                    Console.WriteLine(player.Name + " has lost... since his total points are " + player.TotalPoints);
                }

                player.TotalPoints = 0;
                playerD.TotalPoints = 0;

                Console.WriteLine("\nPress 'Y' to start again or any other key to stop");
            }
            //
        }
    }
}
