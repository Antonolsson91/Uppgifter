using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            foreach (Face f in Enum.GetValues(typeof(Face)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    cards.Add(new Card(f, s));
                }
            }
        }
        public void Shuffle()
        {
            int x = 0;
            foreach(Card card in cards)
            {
                x++;
            }
            for(int i =0; i<52; i++ )
            {
                Random random = new Random();
                int y = random.Next(0, x);
                Card card = cards[y];
                cards.Add(card);
                cards.Remove(card);
            }
        }
        public Card RandomCard()
        {
            Random random = new Random();
            int x = random.Next(cards.Count);
            return cards[x];
        }
    }
}
