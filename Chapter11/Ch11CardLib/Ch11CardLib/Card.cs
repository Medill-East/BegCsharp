using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    public class Card : ICloneable
    {
        public object Clone() => MemberwiseClone();

        private readonly Rank rank;
        private readonly Suit suit;

        /// <summary>
        /// flag for trump uesage.If true , trume are valued higher than cards of othre suits.
        /// </summary>
        public static bool useTrump = false;

        /// <summary>
        /// Trump suit to use if useTrump is true;
        /// </summary>
        public static Suit trump = Suit.Club;

        /// <summary>
        /// flag that determines whether Aces are higher than kings or lower than deuces
        /// </summary>
        public static bool isAceHiger = true;

        private Card()
        {
            throw new System.NotImplementedException();
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The" + rank + "of" + suit + "s";
        }
    }
}