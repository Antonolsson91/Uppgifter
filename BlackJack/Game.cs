using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game

    {
        public int Bet = 100;
        public static Deck deck = new Deck();
        public static void Hit(Players players, Deck deck, List<string> newHand)
        {
            Card randomCard = deck.RandomCard();
            players.hand.Add(randomCard);
            newHand.Add(randomCard.Face.ToString());
        }
        public static void Start()
        {

            deck.Shuffle();


            Players player = new Players("Player", false);
            Players dealer = new Players("Dealer", true);
            List<Players> players = new List<Players> { player, dealer };

            foreach (var p in players)
            {
                p.GenerateHand();
            }
            Console.WriteLine(string.Format("Dealer's hand: #HIDDEN#, {0}", dealer.hand[1].Face.ToString()));
            Console.WriteLine(string.Format("Your hand: {0}, {1} ({2})", player.hand[0].Face.ToString(), player.hand[1].Face.ToString(), player.Total()));


            foreach (Players p in players)
            {
                PlayerAction(p, p.hand);
            }
            Rules(player, dealer);
            Console.ReadKey();

        }
        public static void PlayerAction(Players player, List<Card> hand)
        {

            if (!player.Dealer)
            {
                Console.WriteLine("How much do you wanna bet? ");
                int bet = int.Parse(Console.ReadLine());
                List<string> newHand = new List<string>();
                Console.WriteLine("(H)it or (S)tand?");
                ConsoleKeyInfo choice = Console.ReadKey(true);
                

                if (choice.Key == ConsoleKey.S)
                {
                   
                return;
                }
                else if (choice.Key == ConsoleKey.H)
                {
                     Card randomCard = deck.RandomCard();
                    player.hand.Add(deck.RandomCard());

                    foreach (var card in player.hand)
                    {
                        newHand.Add(card.Face.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Wrong key, try again...");
                    PlayerAction(player, player.hand);
                }
                Console.WriteLine("You got:"  + string.Join(", ", newHand) + "(" + player.Total() + ")");

                if (player.Total() > 21)
                {
                   
                    return;
                }
                else
                {
                    PlayerAction(player, hand);
                }
            }
            else
            {
                Console.WriteLine("Dealer has:" + player.hand[0].Face.ToString() + ", " + player.hand[1].Face.ToString() + "(" + player.Total() + ")");
                if (player.Total() == 21 && player.hand.Count == 2)
                {
                    return;
                }
                else
                {
                    List<string> newHand = new List<string>();
                    foreach (Card card in player.hand)
                    {
                        newHand.Add(card.Face.ToString());
                    }
                    while (player.Total() < 17)
                    {

                        Hit(player, deck, newHand);
                        Console.WriteLine("Dealer got:"+ string.Join(", ", newHand) + "(" + player.Total() + ")\n");
                    }
                    if (player.Total() > 21)
                    {
                        
                        return;
                    }
                }
            }
        }
        public static void Rules(Players player, Players dealer)
        {
            if(player.Total() > 21)
            {
                Console.WriteLine("You got bust!");
                return;
            }
            else if(player.Total() <= 21 && dealer.Total() > 21)
            {
                Console.WriteLine("Dealer busted and you won!");
            }
            else if(player.Total() < 21 && dealer.Total() < 21)
            {
                Console.WriteLine("The dealer won!");
            }
            else if(player.Total() == 21 && dealer.Total() == 21)
            {
                Console.WriteLine("Tie! Both you and the dealer got BlackJack!");
            }
            else if(player.Total() == 21 && player.hand.Count == 2)
            {
                Console.WriteLine("You've got BlackJack and won!");
            }
            else
            {
                if(player.Total() <= 21)
                {
                    if(player.Total() > dealer.Total())
                    {
                        Console.WriteLine("You won!");
                    }
                }
            }

            Console.WriteLine("Play Again? (Y)es or (N)o");
            ConsoleKeyInfo choice = Console.ReadKey(true);
            if (choice.Key == ConsoleKey.Y)
            {
                Start();
            }
            else if (choice.Key == ConsoleKey.N)
            {
                
            }
        }
    }
}
