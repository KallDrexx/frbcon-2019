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
        float maxAISpeed = 10f;
		void CustomInitialize()
		{
            // TODO: I need to figure out the ai paddle movement. I want it to be tighter as the difficulty increases, and drag isn't the right way.
            maxAISpeed = GetMaxAISpeed();

		}

        private float GetMaxAISpeed()
        {
            switch (CurrentDifficultyFactor)
            {
                case DifficultyFactor.Easy: return 175f;
                case DifficultyFactor.Medium: return 225f;
                case DifficultyFactor.Hard: return 275f;

                case DifficultyFactor.ExtraHard:
                default:
                    return 350f;
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
            difference.Normalize();

            PaddleInstance.Acceleration = difference * PaddleAcceleration;
            
            

            var direction = (BallInstance.Y - AIPaddle.Y);

            if (direction > 0.00001f)
            {
                AIPaddle.YVelocity = maxAISpeed;
            }
            else if (direction < -0.00001f)
            {
                AIPaddle.YVelocity = -maxAISpeed;
            }
            else
            {
                AIPaddle.YVelocity = 0;
            }

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
