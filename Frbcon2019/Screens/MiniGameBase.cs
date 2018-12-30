using System;
using FlatRedBall;

namespace Frbcon2019.Screens
{
	public partial class MiniGameBase
	{
		private bool _gameIsActive;
		private TimeSpan _instructionsTimeRemaining;
		private TimeSpan _gameTimeRemaining;

		void CustomInitialize()
		{
			_gameIsActive = false;
			_instructionsTimeRemaining = TimeSpan.FromSeconds(InstructionsDurationInSeconds);
			_gameTimeRemaining = TimeSpan.FromSeconds(GameTimeDurationInSeconds);
			InstructionsTimeLeftText.Text = "Ready!";
			MinigameUI.Visible = false;
			InstructionsDisplayedText.Text = InstructionsText;
			GameTimeLeft.Text = _gameTimeRemaining.Seconds.ToString();
		}

		void CustomActivity(bool firstTimeCalled)
		{
			if (_gameIsActive)
			{
				_gameTimeRemaining -= TimeSpan.FromSeconds(TimeManager.SecondDifference);
				GameTimeLeft.Text = _gameTimeRemaining.Seconds.ToString();
				if (_gameTimeRemaining <= TimeSpan.Zero)
				{
					GlobalData.GameplayData.LastMinigameResult = LastMinigameResult.Loss;
					MoveToScreen(typeof(Scoreboard));
				}
			}
			else
			{
				_instructionsTimeRemaining -= TimeSpan.FromSeconds(TimeManager.SecondDifference);
				var oneThirdTime = (double) InstructionsDurationInSeconds / 3;
				if (oneThirdTime * 2 < _instructionsTimeRemaining.TotalSeconds)
				{
					InstructionsTimeLeftText.Text = "Ready!";
				}
				else if (oneThirdTime <= _instructionsTimeRemaining.TotalSeconds)
				{
					InstructionsTimeLeftText.Text = "Set!";
				}
				else
				{
					InstructionsTimeLeftText.Text = "Go!";
				}

				if (_instructionsTimeRemaining.TotalSeconds <= 0)
				{
					ContentBlocker.Visible = false;
					MinigameUI.Visible = true;
					_gameIsActive = true;
				}
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
