using System;
using System.Collections;
using System.Numerics;
using Tennis_Game;

public class TennisGame
{
	private Program restart;
	private Program _PlayerOne = new Program();
	private Program _PlayerTwo = new Program();

	private string[] score = { "Love", "Fifteen", "Thirty", "Forty", "Advantage", "Game Over" };
	public string PlayGame()
	{
		string message = $"TENNIS GAME!\n{_PlayerOne.nameOne} vs {_PlayerTwo.nameTwo}: who is going to win this game?";
		Console.WriteLine(message);
		return "";
	}

	public string mainGame()
	{
		Random winningRound = new Random();
		int playerOneWinsCount = 0;
		int playerTwoWinsCount = 0;
		int count1 = 0;
		int count2 = 0;
		bool winnerCheck = false;
		while (playerOneWinsCount <= 5 && playerTwoWinsCount <= 5 && winnerCheck == false)
		{
			int randomNumber = winningRound.Next(0, 3);
			if (randomNumber == 1 && winnerCheck == false)
			{
				count1 = count1 + 1;
				playerOneWinsCount = playerOneWinsCount + 1;
				Console.WriteLine(_PlayerOne.nameOne + " " + score[playerOneWinsCount - 1]);
			}
			else if (randomNumber == 2 && winnerCheck == false)
			{
				count2 = count2 + 1;
				playerTwoWinsCount = playerTwoWinsCount + 1;
				Console.WriteLine(_PlayerTwo.nameTwo + " " + score[playerTwoWinsCount - 1]);
			}
			if (playerOneWinsCount >= 4 && playerOneWinsCount + -2 >= playerTwoWinsCount || playerTwoWinsCount >= 4 && playerTwoWinsCount - 2 >= playerOneWinsCount)
			{
				winnerCheck = true;
				if (playerOneWinsCount > playerTwoWinsCount)
				{
					Console.WriteLine("Winner is..." + " " + _PlayerOne.nameOne);

				}
				else
				{
					Console.WriteLine("Winner is..." + " " + _PlayerTwo.nameTwo);
				}
				playerOneWinsCount = 0;
				playerTwoWinsCount = 0;
			}
		}
		Console.WriteLine("");
		return null;
	}
}
