using System;
using System.Linq;
using FlatRedBall;
using Frbcon2019.GumRuntimes;

namespace Frbcon2019.Screens
{
	public partial class Scoreboard
	{
		private TimeSpan _timeLeft;

		void CustomInitialize()
		{
			_timeLeft = TimeSpan.FromSeconds(SecondsUntilNextGameStarts);
			TimerValue.Text = _timeLeft.Seconds.ToString();

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
			_timeLeft -= TimeSpan.FromSeconds(TimeManager.SecondDifference);
			TimerValue.Text = _timeLeft > TimeSpan.FromSeconds(1)
				? _timeLeft.Seconds.ToString()
				: "GO!";

			if (_timeLeft <= TimeSpan.Zero)
			{
				MoveToScreen(typeof(MemoryGame));
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
