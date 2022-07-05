using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Cards
{
    class Card
    {
        private string face;
        private string suit;
        public string Face
        {
            get => this.face; private set
            {
                {
                    if (!char.IsUpper(value[0]) && !char.IsDigit(value[0]) || value.Length > 2)
                    {
                        throw new ArgumentException();
                    }
                    this.face = value;
                }
            }
        }
        public string Suit
        {
            get => this.suit; private set
            {
                {
                    if (!char.IsUpper(value[0]))
                    {
                        throw new ArgumentException();
                    }
                    this.suit = value;
                }
            }
        }
        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (this.Suit)
            {
                case "S":
                    sb.Append($"[{this.Face}\u2660]");
                    break;
                case "H":
                    sb.Append($"[{this.Face}\u2665]");
                    break;
                case "D":
                    sb.Append($"[{this.Face}\u2666]");
                    break;
                case "C":
                    sb.Append($"[{this.Face}\u2663]");
                    break;
            }
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<Card>();
            var cards = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cards.Length; i += 2)
            {
                try
                {
                    var cardFace = cards[i];
                    var cardSuit = cards[i + 1];
                    var card = new Card(cardFace, cardSuit);
                    deck.Add(card);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid card!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid card!");
                }
            }
            foreach (var card in deck)
            {
                Console.Write(card.ToString() + " ");
            }
        }
    }
}
