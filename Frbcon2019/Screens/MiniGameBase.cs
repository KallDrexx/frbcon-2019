using System;
using FlatRedBall;
using Frbcon2019.GumRuntimes;

namespace Frbcon2019.Screens
{
	public partial class MiniGameBase
	{
		private bool _gameIsActive;
		private double _instructionsStartedAt;
		private double _gameStartedAt;

		protected bool GameIsActive => _gameIsActive;

		protected void TriggerWinCondition()
		{
			GlobalData.GameplayData.LastMinigameResult = LastMinigameResult.Win;
			MoveToScreen(typeof(Scoreboard));
		}

		protected void TriggerLoseCondition()
		{
			GlobalData.GameplayData.LastMinigameResult = LastMinigameResult.Loss;
			MoveToScreen(typeof(Scoreboard));
		}

		protected virtual void GameStarted()
		{

		}

		protected DifficultyFactor CurrentDifficultyFactor => GlobalData.GameplayData.CurrentDifficultyFactor;
		protected bool IsInGame => _gameIsActive;

		void CustomInitialize()
		{
			_gameIsActive = false;
			_instructionsStartedAt = PauseAdjustedCurrentTime;
			InstructionsTimeLeftText.Text = "Ready!";
			InstructionsDisplayedText.Text = InstructionsText;
			GameTimeLeft.Text = GameTimeDurationInSeconds.ToString();
			MiniGameBaseGumRuntime.ApplyState(MiniGameBaseGumRuntime.GameState.InstructionScreen.ToString());
			ContentBlocker.Z = 11;
		}

		void CustomActivity(bool firstTimeCalled)
		{
			if (_gameIsActive)
			{
				var secondsRemaining = GameTimeDurationInSeconds - PauseAdjustedSecondsSince(_gameStartedAt);
				GameTimeLeft.Text = ((int) secondsRemaining).ToString();
				if (secondsRemaining <= 0)
				{
					GlobalData.GameplayData.LastMinigameResult = LastMinigameResult.Loss;
					MoveToScreen(typeof(Scoreboard));
				}
			}
			else
			{
				var secondsRemaining = InstructionsDurationInSeconds - PauseAdjustedSecondsSince(_instructionsStartedAt);
				var oneThirdTime = (double) InstructionsDurationInSeconds / 3;
				if (oneThirdTime * 2 < secondsRemaining)
				{
					InstructionsTimeLeftText.Text = "Ready!";
				}
				else if (oneThirdTime <= secondsRemaining)
				{
					InstructionsTimeLeftText.Text = "Set!";
				}
				else
				{
					InstructionsTimeLeftText.Text = "Go!";
				}

				if (secondsRemaining <= 0)
				{
					_gameIsActive = true;
					_gameStartedAt = PauseAdjustedCurrentTime;
					MiniGameBaseGumRuntime.ApplyState(MiniGameBaseGumRuntime.GameState.GameActive.ToString());
					GameStarted();
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
