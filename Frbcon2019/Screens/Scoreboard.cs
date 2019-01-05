using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FlatRedBall;
using Frbcon2019.GumRuntimes;

namespace Frbcon2019.Screens
{
	public partial class Scoreboard
	{
		private static readonly Type[] AvailableMiniGames;
		private static readonly Random Random = new Random();
		private double _startedAt;

		static Scoreboard()
		{
			AvailableMiniGames = Assembly.GetExecutingAssembly()
				.GetTypes()
				.Where(x => typeof(MiniGameBase).IsAssignableFrom(x))
				.Where(x => x != typeof(MiniGameBase))
				.ToArray();
		}

		void CustomInitialize()
		{
			_startedAt = PauseAdjustedCurrentTime;
			TimerValue.Text = SecondsUntilNextGameStarts.ToString();

			HandleGamePlayed();

			for (var x = 0; x < GlobalData.GameplayData.MaxLives; x++)
			{
				var indicator = new LifeIconRuntime();
				if (x >= GlobalData.GameplayData.LivesLeft)
				{
					indicator.ApplyState("Lost");
				}

				indicator.Parent = LivesContainer;
			}

			LivesValue.Text = GlobalData.GameplayData.LivesLeft.ToString();
			ScoreValue.Text = GlobalData.GameplayData.CurrentScore.ToString();
			DifficultyValue.Text = GlobalData.GameplayData.CurrentDifficultyFactor.ToString();
		}

		void CustomActivity(bool firstTimeCalled)
		{
			var timeLeft = SecondsUntilNextGameStarts - PauseAdjustedSecondsSince(_startedAt);
			TimerValue.Text = timeLeft >= 1
				? ((int)timeLeft).ToString()
				: "GO!";

			if (timeLeft <= 0)
			{
				if (!string.IsNullOrWhiteSpace(ForcedMinigameType))
				{
					MoveToScreen(ForcedMinigameType);
				}
				else
				{
					while (true)
					{
						var index = Random.Next(0, AvailableMiniGames.Length);
						var nextGameType = AvailableMiniGames[index];
						if (AvailableMiniGames.Length > 1 && nextGameType != GlobalData.GameplayData.LastMiniGameTypePlayed)
						{
							GlobalData.GameplayData.LastMiniGameTypePlayed = nextGameType;
							MoveToScreen(AvailableMiniGames[index]);
							break;
						}
					}
				}
			}
		}

		void CustomDestroy()
		{
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }

        private void HandleGamePlayed()
        {
	        if (GlobalData.GameplayData.LastMinigameResult == LastMinigameResult.None)
	        {
		        return;
	        }

	        GlobalData.GameplayData.GamesPlayed++;
	        if (GlobalData.GameplayData.GamesPlayed % NumberOfGamesBeforeDifficultyIncrease == 0)
	        {
		        GlobalData.GameplayData.CurrentDifficultyFactor += 1;

		        var maxDifficultyFactor = Enum.GetValues(typeof(DifficultyFactor))
			        .Cast<int>()
			        .Max();

		        if ((int)GlobalData.GameplayData.CurrentDifficultyFactor > maxDifficultyFactor)
		        {
			        GlobalData.GameplayData.CurrentDifficultyFactor = (DifficultyFactor) maxDifficultyFactor;
		        }
	        }

	        switch (GlobalData.GameplayData.LastMinigameResult)
	        {
		        case LastMinigameResult.Win:
			        GlobalData.GameplayData.CurrentScore += 1;
			        ScoreboardGumRuntime.ApplyState("Win");
			        break;

		        case LastMinigameResult.Loss:
			        GlobalData.GameplayData.LivesLeft -= 1;
			        ScoreboardGumRuntime.ApplyState("Lose");

			        if (GlobalData.GameplayData.LivesLeft <= 0)
			        {
				        MoveToScreen(typeof(GameOver));
			        }

			        break;
	        }
        }
	}
}
