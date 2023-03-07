using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal static class Testing
    {
        static Pack pack;

        // Test all the features
        public static void StartTesting()
        {
            pack = new Pack();

            Pack.shuffleCardPack(0);
            Pack.shuffleCardPack(1);
            foreach (var card1 in Pack.Deck)
            {
                card1.ReadCard();
            }
            pack = new Pack();
            Pack.shuffleCardPack(3);
            foreach (var card1 in Pack.Deck)
            {
                card1.ReadCard();
            }
            Pack.shuffleCardPack(2);
            foreach (var card1 in Pack.Deck)
            {
                card1.ReadCard();
            }

            Card card = Pack.deal();
            Console.WriteLine("\nDeal Card");
            card.ReadCard();

            List<Card> hand = new List<Card>();
            hand = Pack.dealCard(3);
            Console.WriteLine("\nDeal Cards");
            foreach (var card1 in hand)
            {
                card1.ReadCard();
            }
        }
    }
}
