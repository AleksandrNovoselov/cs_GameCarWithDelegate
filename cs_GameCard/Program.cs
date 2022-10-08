using System;
using System.Linq;

namespace cs_GameCard
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numbersPlayers;
            Console.WriteLine("Введите количество игоков от 2 до 6");
            do
            {
                numbersPlayers = int.Parse(Console.ReadLine());

            } while (!Enumerable.Range(2, 6).Contains(numbersPlayers));

            Game game = new Game(numbersPlayers);

            while (game.gameTurn())
            { }

            Console.WriteLine("Конец игры");

            Console.ReadKey();
        }
    }
}