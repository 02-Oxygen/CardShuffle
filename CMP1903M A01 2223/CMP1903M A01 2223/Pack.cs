using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> Deck { get; set; }
        //Constructor
        public Pack()
        {
            Deck = createPack();
        }

        //Picks which shuffle option
        // 1 - FisherYates
        // 2 - Riffle
        // 3 - None
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                default:
                    Console.WriteLine($"\n{typeOfShuffle} is invalid");
                    return false;
                case 1:
                    Console.WriteLine("\nFisherYates Shuffle selected");
                    Deck = Shuffle.FisherYatesShuffle(Deck);
                    break;
                case 2:
                    Console.WriteLine("\nRiffle Shuffle selected");
                    Deck = Shuffle.RiffleShuffle(Deck);
                    break;
                case 3:
                    Console.WriteLine("\nNo shuffle Selected");
                    break;
            }
            return true;

        }
        // deals one card
        //places card in varaible
        //remove card from pack
        //returns variable
        public static Card deal()
        {
            Card card = Deck[0];
            Deck.RemoveAt(0);
            return card;
        }

        // deal multiple cards
        //based on parameter
        public static List<Card> dealCard(int amount)
        {
            List<Card> temp = new List<Card>();

            //Deals the number of cards specified by 'amount'

            for (int i = 0; i < amount; i++)
            {
                temp.Add(deal());
            }
            return temp;
        }

        //create teh inital pack
        public static List<Card> createPack()
        {
            List<Card> temp = new List<Card>();
            // 1 - 4 for suits
            for (int i = 0; i < 4; i++)
            {
                // 1 -13 for value
                for (int index = 0; index < 13; index++)
                {
                    temp.Add(new Card(index + 1, i + 1));
                }
            }

            return temp;
        }

    }
}
