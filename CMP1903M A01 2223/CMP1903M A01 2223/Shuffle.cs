using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal static class Shuffle
    {
        public static List<Card> FisherYatesShuffle(List<Card> Deck)
        {
            Card[] array = new Card[Deck.Count];
            int[] ind = new int[Deck.Count];
            int index;
            Random random = new Random();

            for (int i = 0; i < Deck.Count; i++)
            {
                ind[i] = 0;
            }

            for (int i = 0; i < Deck.Count; i++)
            {
                do
                {
                    index = random.Next(Deck.Count);
                } while (ind[index] != 0);

                ind[index] = 1;
                array[i] = Deck[index];
            }

            return array.ToList();
        }

        public static List<Card> RiffleShuffle(List<Card> Deck)
        {
            Random random = new Random();
            int replacements = random.Next(100, 1000);

            for (int i = 0; i < replacements; i++)
            {
                int A = random.Next(Deck.Count);
                int B = random.Next(Deck.Count);

                Card a = Deck[A];
                Card b = Deck[B];

                Card temp = a;
                a = b;
                b = temp;

                Deck[A] = a;
                Deck[B] = b;
            }

            return Deck;
        }
    }
}
