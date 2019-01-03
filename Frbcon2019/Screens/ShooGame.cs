using System;
using System.Collections.Generic;
using System.Linq;
using FlatRedBall;
using FlatRedBall.Gui;
using Frbcon2019.Entities.ShooGame;

namespace Frbcon2019.Screens
{
	public partial class ShooGame
	{
		private readonly List<Mouse> _mice = new List<Mouse>();
		private double? _timeSinceLastClick;

		void CustomInitialize()
		{
			SpawnMice();
		}

		void CustomActivity(bool firstTimeCalled)
		{
			var cursorX = GuiManager.Cursor.WorldXAt(0);
			var cursorY = GuiManager.Cursor.WorldYAt(0);

			BroomInstance.X = cursorX;
			BroomInstance.Y = cursorY + 40;

			if (_timeSinceLastClick != null)
			{
				if (PauseAdjustedSecondsSince(_timeSinceLastClick.Value) > SecondsForBroomSweep)
				{
					_timeSinceLastClick = null;
					BroomInstance.SpriteInstanceRotationZ *= -1;
				}
			}
			else
			{
				if (GuiManager.Cursor.PrimaryClick)
				{
					_timeSinceLastClick = PauseAdjustedCurrentTime;
					BroomInstance.SpriteInstanceRotationZ *= -1;

					foreach (var mouse in _mice)
					{
						mouse.ReactToBroomSweep(cursorX, cursorY);
					}
				}
			}

			// Check if all the mice are off the screen
			var miceRemaining = _mice.Count;
			foreach (var mouse in _mice)
			{
				if (!mouse.IsInView())
				{
					miceRemaining--;
				}
			}

			if (miceRemaining == 0)
			{
				TriggerWinCondition();
			}
		}

		void CustomDestroy()
		{
			foreach (var mouse in _mice)
			{
				mouse.Destroy();
			}
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }

        private void SpawnMice()
        {
	        const int pixelBuffer = 50;
	        var numberOfMice = GetNumberOfMiceOnBoard();
	        var random = new Random();
	        foreach (var _ in Enumerable.Range(0, numberOfMice))
	        {
		        var minX = (int) Camera.Main.AbsoluteLeftXEdgeAt(0) + pixelBuffer;
		        var maxX = (int) Camera.Main.AbsoluteRightXEdgeAt(0) - pixelBuffer;
		        var minY = (int) Camera.Main.AbsoluteBottomYEdgeAt(0) + pixelBuffer;
		        var maxY = (int) Camera.Main.AbsoluteTopYEdgeAt(0) - pixelBuffer;

		        var mouse = new Mouse
		        {
			        X = random.Next(minX, maxX),
			        Y = random.Next(minY, maxY),
		        };

		        _mice.Add(mouse);
	        }
        }

        private int GetNumberOfMiceOnBoard()
        {
	        switch (CurrentDifficultyFactor)
	        {
		        case DifficultyFactor.Easy: return 3;
		        case DifficultyFactor.Medium: return 5;
		        case DifficultyFactor.Hard: return 10;

		        case DifficultyFactor.ExtraHard:
			    default:
			        return 20;
	        }
        }
	}
}
