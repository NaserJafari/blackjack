using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Deck
    {
        public Cards[] cardDeck;
        
        public Deck() 
        {
            //name, number, value, color, type
            cardDeck = new Cards[]
            {
                new Cards("Ace of hearts", 1, 1, "red", "hearts"),
                new Cards("Two of hearts", 2, 2, "red", "hearts"),
                new Cards("Three of hearts", 3, 3, "red", "hearts"),
                new Cards("Four of hearts", 4, 4, "red", "hearts"),
                new Cards("Five of hearts", 5, 5, "red", "hearts"),
                new Cards("Six of hearts", 6, 6, "red", "hearts"),
                new Cards("Seven of hearts", 7, 7, "red", "hearts"),
                new Cards("Eight of hearts", 8, 8, "red", "hearts"),
                new Cards("Nine of hearts", 9, 9, "red", "hearts"),
                new Cards("Ten of hearts", 10, 10, "red", "hearts"),
                new Cards("Jack of hearts", 10, 10, "red", "hearts"),
                new Cards("Queen of hearts", 10, 10, "red", "hearts"),
                new Cards("King of hearts", 10, 10, "red", "hearts"),
                new Cards("Ace of spades", 1, 1, "black", "spades"),
                new Cards("Two of spades", 2, 2, "black", "spades"),
                new Cards("Three of spades", 3, 3, "black", "spades"),
                new Cards("Four of spades", 4, 4, "black", "spades"),
                new Cards("Five of spades", 5, 5, "black", "spades"),
                new Cards("Six of spades", 6, 6, "black", "spades"),
                new Cards("Seven of spades", 7, 7, "black", "spades"),
                new Cards("Eight of spades", 8, 8, "black", "spades"),
                new Cards("Nine of spades", 9, 9, "black", "spades"),
                new Cards("Ten of spades", 10, 10, "black", "spades"),
                new Cards("Jack of spades", 10, 10, "black", "spades"),
                new Cards("Queen of spades", 10, 10, "black", "spades"),
                new Cards("King of spades", 10, 10, "black", "spades"),
                new Cards("Ace of diamonds", 1, 1, "red", "diamonds"),
                new Cards("Two of diamonds", 2, 2, "red", "diamonds"),
                new Cards("Three of diamonds", 3, 3, "red", "diamonds"),
                new Cards("Four of diamonds", 4, 4, "red", "diamonds"),
                new Cards("Five of diamonds", 5, 5, "red", "diamonds"),
                new Cards("Six of diamonds", 6, 6, "red", "diamonds"),
                new Cards("Seven of diamonds", 7, 7, "red", "diamonds"),
                new Cards("Eight of diamonds", 8, 8, "red", "diamonds"),
                new Cards("Nine of diamonds", 9, 9, "red", "diamonds"),
                new Cards("Ten of diamonds", 10, 10, "red", "diamonds"),
                new Cards("Jack of diamonds", 10, 10, "red", "diamonds"),
                new Cards("Queen of diamonds", 10, 10, "red", "diamonds"),
                new Cards("King of diamonds", 10, 10, "red", "diamonds"),
                new Cards("Ace of clubs", 1, 1, "black", "clubs"),
                new Cards("Two of clubs", 2, 2, "black", "clubs"),
                new Cards("Three of clubs", 3, 3, "black", "clubs"),
                new Cards("Four of clubs", 4, 4, "black", "clubs"),
                new Cards("Five of clubs", 5, 5, "black", "clubs"),
                new Cards("Six of clubs", 6, 6, "black", "clubs"),
                new Cards("Seven of clubs", 7, 7, "black", "clubs"),
                new Cards("Eight of clubs", 8, 8, "black", "clubs"),
                new Cards("Nine of clubs", 9, 9, "black", "clubs"),
                new Cards("Ten of clubs", 10, 10, "black", "clubs"),
                new Cards("Jack of clubs", 10, 10, "black", "clubs"),
                new Cards("Queen of clubs", 10, 10, "black", "clubs"),
                new Cards("King of clubs", 10, 10, "black", "clubs"),
            };
        }

        public void ShuffleDeck()
        {
            Random randomCard = new Random();
            for (int i = cardDeck.Length - 1; i >= 0; i--) 
            {
                int j = randomCard.Next(i + 1);
                Cards temp = cardDeck[i];
                cardDeck[i] = cardDeck[j];
                cardDeck[j] = temp;
            }
        }
         
        public void NewCard()
        {
            ShuffleDeck();
            Cards[] dealtCards = new Cards[2];
            dealtCards[0] = cardDeck[0];
            dealtCards[1] = cardDeck[1];
            cardDeck = cardDeck.Skip(2).ToArray();

            Console.WriteLine("Dit zijn jouw kaarten: ");
            foreach (Cards card in dealtCards)
            {
                Console.WriteLine(card.name);
            }
        }
    }
}
