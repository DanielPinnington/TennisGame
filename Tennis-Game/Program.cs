using System;
using System.Data;
namespace Tennis_Game
{
    class Program
    {
        public string nameOne = "Bruce";
        public string nameTwo = "Bill";
        static void Main(string[] args)
        {
            coinFlip();
        }
        public static void coinFlip()
        {
            int heads = 0;
            int tails = 1;
            int count = 0;
            var startGame = new TennisGame();
            Random coinFlip = new Random();
            startGame.PlayGame();

            Console.WriteLine("Press any key to play game");
            string anyKey = Console.ReadLine();

            while (count < 1)
            {
                int randomNumber = coinFlip.Next(0, 2);
                count = count + 1;
                if (randomNumber == heads)
                {
                    Console.WriteLine("COIN HAS BEEN FLIPPED - HEADS!\n" + "FIRST SERVE!\n");
                }
                else if (randomNumber == tails)
                {
                    Console.WriteLine("COIN HAS BEEN FLIPPED - Tails!\n" + "FIRST SERVE!\n");
                }
            }
            startGame.mainGame();
        }
    }
}
