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
        public Pack()
        {
            Deck = createPack();
        }


        public static bool shuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                default:
                    Console.WriteLine($"{typeOfShuffle} is invalid");
                    return false;
                case 1:
                    Console.WriteLine("FisherYates Shuffle selected");
                    Deck = Shuffle.FisherYatesShuffle(Deck);
                    break;
                case 2:
                    Console.WriteLine("Riffle Shuffle selected");
                    Deck = Shuffle.RiffleShuffle(Deck);
                    break;
                case 3:
                    Console.WriteLine("No shuffle Selected");
                    break;
            }
            return true;

        }
        public static Card deal()
        {
            Card card = Deck[0];
            Deck.RemoveAt(0);
            return card;
        }
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

        public static List<Card> createPack()
        {
            List<Card> temp = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int index = 0; index < 13; index++)
                {
                    temp.Add(new Card(index + 1, i + 1));
                }
            }

            return temp;
        }

    }
}
