using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10CardLib
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52]; //constructor implemented, creating and assigning 52 cards in cards field
            for (int suitVal = 0; suitVal < 4; suitVal++) 
            {
                for (int rankVaL = 1; rankVaL < 14; rankVaL++)
                {
                    cards[suitVal * 13 + rankVaL - 1] = new Card((Suit)suitVal,
                        (Rank)rankVaL);
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

        public void Shuffle() //copies existing card array randomly into temporary card array, 
                             //cheking if cards are not repeating
        {
            Card[] newDeck = new Card[52]; 
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i =0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0); //copies each of the cars in newDeck back into cards

        }

    }
}
