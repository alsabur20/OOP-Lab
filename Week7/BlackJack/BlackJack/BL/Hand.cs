using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    class Hand
    {
        List<Card> hand = new List<Card>();
        public Hand()
        {
        }
        public void clear()
        {
            this.hand.Clear();
        }
        public void addCard(Card c)
        {
            this.hand.Add(c);
        }
        public void removeCard(Card c)
        {
            if (this.hand.Contains(c))
            {
                this.hand.Remove(c);
            }
        }
        public void removeCard(int position)
        {
            this.hand.RemoveAt(position);
        }
        public int GetCardCount()
        {
            return this.hand.Count;
        }
        public Card getard(int position)
        {
            return this.hand[position];
        }
        public void sortByValue()
        {

        }
    }
}
