using System;
using System.Security.Cryptography.X509Certificates;

public class Game
{
	private int IP;
	private static int GameCount = 1;
	public Game(int Rating, GameAccount Player1, GameAccount Player2)
	{
		if (Math.Max(Player1.CurrentRating, Player2.CurrentRating) < Rating || Rating < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(Rating));
		}
		else
		{
			IP = GameCount++;
			Random random = new Random();
			if (random.Next(0, 10) < 5)
			{
				Player1.WinGame(IP, Rating, Player2);
				Player2.LoseGame(IP, Rating,Player1);
			}
			else
			{
				Player2.WinGame(IP, Rating, Player1);
				Player1.LoseGame(IP, Rating, Player2);
			}
		}
	}
}
