using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class Deck
    {
        private Cards cards = new Cards();

        public Deck()
        {
            // Line of code removed here
            for (int suitVal = 0; suitVal < 4; suitVal++) 
            {
                for (int rankVaL = 1; rankVaL < 14; rankVaL++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVaL));
                }
            }
        }
                
        public Card GetCard(int cardNum) //either returns the Cards objects with the requested index or throws an exception
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw
                    (new System.ArgumentOutOfRangeException("cardNum", cardNum, 
                    "Value must be between 0 and 51."));
        }

        public void Shuffle() 
        {
            Cards newDeck = new Cards(); 
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i =0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck[sourceCard] = cards[i];
            }
            newDeck.CopyTo(cards); //copies each of the cars in newDeck back into cards

        }

    }
}
