using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Players
    {
        public List<Card> hand = new List<Card>();
        public string Name { get; set; }
        public bool Dealer { get; set; }

        public void GenerateHand()
        {
            for (int i = 0; i < 2; i++)
            {
                Card card = Game.deck.RandomCard();
                hand.Add(card);
               Game.deck.cards.Remove(card);
            }
        }

        public int Total()
        {
            int total = 0;

            foreach (var card in hand)
            {
                Face face;
                int value;
                if (Enum.TryParse(card.Face.ToString(), out face))
                {
                    value = (int)face;
                    total += value;
                }
            }

            return total;
        }

        public Players(string name, bool dealer)
        {
            Name = name;
            Dealer = dealer;
        }
    }
}
