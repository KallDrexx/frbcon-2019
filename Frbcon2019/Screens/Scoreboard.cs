using System;
using FlatRedBall;

namespace Frbcon2019.Screens
{
	public partial class Scoreboard
	{
		private TimeSpan _timeLeft;

		void CustomInitialize()
		{
			_timeLeft = TimeSpan.FromSeconds(SecondsUntilNextGameStarts);
			TimerValue.Text = _timeLeft.Seconds.ToString();

			WinText.Visible = GlobalData.GameplayData.LastMinigameResult == LastMinigameResult.Win;
			FailText.Visible = GlobalData.GameplayData.LastMinigameResult == LastMinigameResult.Loss;

			if (GlobalData.GameplayData.LastMinigameResult == LastMinigameResult.Win)
			{
				GlobalData.GameplayData.CurrentScore += 1;
			}
			else if (GlobalData.GameplayData.LastMinigameResult == LastMinigameResult.Loss)
			{
				GlobalData.GameplayData.LivesLeft -= 1;

				if (GlobalData.GameplayData.LivesLeft <= 0)
				{
					MoveToScreen(typeof(MainMenu));
					return;
				}
			}

			LivesValue.Text = GlobalData.GameplayData.LivesLeft.ToString();
			ScoreValue.Text = GlobalData.GameplayData.CurrentScore.ToString();
		}

		void CustomActivity(bool firstTimeCalled)
		{
			_timeLeft -= TimeSpan.FromSeconds(TimeManager.SecondDifference);
			TimerValue.Text = _timeLeft > TimeSpan.FromSeconds(1)
				? _timeLeft.Seconds.ToString()
				: "GO!";

			if (_timeLeft <= TimeSpan.Zero)
			{
				MoveToScreen(typeof(MiniGameBase));
			}
		}

		void CustomDestroy()
		{
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }
	}
}
