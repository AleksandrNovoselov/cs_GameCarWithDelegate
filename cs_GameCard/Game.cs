using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_GameCard
{
    public class Game
    {
        private const int numbersCard = 36;

        public List<Karta> CardDeck { get; private set; }
        public List<Player> Players { get; }
        public Random Rand { get; }

        public Game(int numbersPlayers)
        {
            Rand = new Random();
            Players = new List<Player>();

            for (int i = 0; i < numbersPlayers; i++)
            {
                Players.Add(new Player());
            }

            CardDeck = CreateCardDeck();

            var CardDeckRand = Shufflу();

            RazdatCards(Players, CardDeckRand);
        }

        public bool gameTurn()
        {
            Console.WriteLine("Нажми Enter для хода");
            Console.ReadLine();
            Console.WriteLine("Игрок\tКол-во карт\tКарта");

            int maxValue = int.MinValue;
            Player playerMaxValue = null;
            Queue<Karta> cardQueue = new Queue<Karta>();

            for (int i = 0; i < Players.Count; i++)
            {
                Player currentPlaer = Players[i];

                if (currentPlaer.cards.Count > 0)
                {
                    Karta card = currentPlaer.cards[0];

                    Console.WriteLine($"{i + 1}\t\t{currentPlaer.cards.Count}\t{card}");

                    currentPlaer.cards.Remove(card);

                    if ((int)card.value > maxValue)
                    {
                        maxValue = (int)card.value;
                        playerMaxValue = currentPlaer;
                    }

                    cardQueue.Enqueue(card);
                }
            }

            playerMaxValue.cards.AddRange(cardQueue);

            Console.WriteLine($"Забрал игрок >> {Players.IndexOf(playerMaxValue) + 1} <<\n");

            if (playerMaxValue.cards.Count == numbersCard)
            {
                Console.WriteLine($"Победил игрок номер >> {Players.IndexOf(playerMaxValue) + 1} <<");
                return false;
                //ниразу никто не победил 
            }

            return true;
        }

        public void RazdatCards(List<Player> players, IEnumerable<Karta> CardDeck)
        {
            int currentPlayer = 0;

            foreach (var card in CardDeck)
            {
                players[currentPlayer].cards.Add(card);

                currentPlayer++;
                currentPlayer %= players.Count;
            }
        }

        public List<Karta> CreateCardDeck()
        {
            CardDeck = new List<Karta>();

            for (int i = 0; i < numbersCard / 4; i++)
            {
                CardDeck.Add(new Karta((KartaValue)i, 0));
                CardDeck.Add(new Karta((KartaValue)i, (KartaSuit)1));
                CardDeck.Add(new Karta((KartaValue)i, (KartaSuit)2));
                CardDeck.Add(new Karta((KartaValue)i, (KartaSuit)3));
            }

            return CardDeck;
        }

        public IEnumerable<Karta> Shufflу()
        {
            var randomize = CardDeck.OrderBy(item => Rand.Next());

            //foreach (var value in randomize)
            //{
            //    Console.WriteLine(value);
            //}
            return randomize;
        }
    }
}