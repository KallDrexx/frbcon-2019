using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using FlatRedBall.Gui;
using Frbcon2019.Entities.BeefBall;
using Microsoft.Xna.Framework;

namespace Frbcon2019.Screens
{
	public partial class BeefBallGame
	{

		void CustomInitialize()
		{
            // TODO: I need to figure out the ai paddle movement. I want it to be tighter as the difficulty increases, and drag isn't the right way.
            AIPaddle.Drag = GetDrag();

		}

        private float GetDrag()
        {
            switch (CurrentDifficultyFactor)
            {
                case DifficultyFactor.Easy: return 10f;
                case DifficultyFactor.Medium: return 5f;
                case DifficultyFactor.Hard: return 2f;

                case DifficultyFactor.ExtraHard:
                default:
                    return 0f;
            }
        }

        void CustomActivity(bool firstTimeCalled)
        {
            if (!GameIsActive)
            {
                return;
            }

            var cursorX = GuiManager.Cursor.WorldXAt(0);
            var cursorY = GuiManager.Cursor.WorldYAt(0);

            var cursorPosition = new Vector3(cursorX, cursorY, 0);
            var difference = cursorPosition - PaddleInstance.Position;

            PaddleInstance.Acceleration = difference * PaddleMovementSpeed;

            AIPaddle.YAcceleration = (BallInstance.Y - AIPaddle.Y) * PaddleMovementSpeed;

            BallInstance.CollideAgainstBounce(PaddleInstance, 0, 1, 1);
            BallInstance.CollideAgainstBounce(AIPaddle, 0, 1, 1);
            BallInstance.CollideAgainstBounce(Boundaries, 0, 1, 1);

            if (BallInstance.CollideAgainst(GoalInstance))
            {
                TriggerWinCondition();
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
