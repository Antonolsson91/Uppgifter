using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public Face Face { get; set; }

        public Suit Suit { get; set; }

        public Card(Face face, Suit suit)
        {
            Face = face;
            Suit = suit;
        }
    }
}
