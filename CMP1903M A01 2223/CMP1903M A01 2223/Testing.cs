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

        public static void StartTesting()
        {
            pack = new Pack();

            Pack.shuffleCardPack(0);
            Pack.shuffleCardPack(1);
            Pack.shuffleCardPack(2);
            Pack.shuffleCardPack(3);

            Card card = Pack.deal();
            Console.WriteLine($"Value: {card.Value} Suit: {card.Suit}");

            List<Card> hand = new List<Card>();
            hand = Pack.dealCard(3);

            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine($"Value: {hand[i].Value} Suit: {hand[i].Suit}");
            }
        }
    }
}
