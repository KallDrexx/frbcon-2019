using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using StateInterpolationPlugin;

namespace Frbcon2019.Entities.BabyCatcher
{
	public partial class CatcherOfBabies
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{


		}

        public void PlayCatchAnimation()
        {

            var shaker = new ShakeTweener
            {
                Amplitude = ShakeAmplitude,
                Duration = ShakeSeconds
            };
            shaker.PositionChanged += position =>
            {
                CarriageInstance.RelativeRotationZ = MathHelper.ToRadians(position);
                CarriageInstance.RelativeY = Math.Abs(position) * -2;
            };
            TweenerManager.Self.Add(shaker);
            shaker.Start();
        }


        const float maxLerpSeconds = .02f;
        float thisLerp;
        private void CustomActivity()
		{
            thisLerp = 1.0f / maxLerpSeconds * TimeManager.SecondDifference;

            LerpAxle();
            LerpHandle();
            LerpWheels();
        }

        private void LerpWheels()
        {
            LerpLeftWheel();
            LerpRightWheel();
        }

        private void LerpRightWheel()
        {
            var endPosition = this.Position;
            endPosition += this.RotationMatrix.Down * 97;
            endPosition += this.RotationMatrix.Right * 62;

            var distance = Vector3.Distance(RightWheelInstance.Position, endPosition);


            if (distance > .0001f)
            {
                RightWheelInstance.Position = Vector3.Lerp(RightWheelInstance.Position, endPosition, thisLerp);
            }
            else
            {
                if (distance > 0.0f)
                {

                }

                RightWheelInstance.Position = endPosition;
                RightWheelInstance.Z -= 2f;
            }
        }

        private void LerpLeftWheel()
        {
            var endPosition = this.Position;
            endPosition += this.RotationMatrix.Down * 97;
            endPosition += this.RotationMatrix.Left * 62;

            var distance = Vector3.Distance(LeftWheelInstance.Position, endPosition);


            if (distance > .0001f)
            {
                LeftWheelInstance.Position = Vector3.Lerp(LeftWheelInstance.Position, endPosition, thisLerp);
            }
            else
            {
                if (distance > 0.0f)
                {

                }

                LeftWheelInstance.Position = endPosition;
                LeftWheelInstance.Z -= 2f;
            }
        }

        private void LerpHandle()
        {
            var endPosition = this.Position;
            endPosition += this.RotationMatrix.Up * 10;
            endPosition += this.RotationMatrix.Right * 86;
            endPosition.Z += 1;

            var distance = Vector3.Distance(HandleInstance.Position, endPosition);


            if (distance > .0001f)
            {
                HandleInstance.Position = Vector3.Lerp(HandleInstance.Position, endPosition, thisLerp);
            }
            else
            {
                if (distance > 0.0f)
                {

                }

                HandleInstance.Position = endPosition;
            }
        }

        private void LerpAxle()
        {
            var endPosition = this.Position;
            endPosition += this.RotationMatrix.Down * 72;
            var distance = Vector3.Distance(AxleInstance.Position, endPosition);


            if (distance > .0001f)
            {
                AxleInstance.Position = Vector3.Lerp(AxleInstance.Position, endPosition, thisLerp);
            }
            else
            {
                if (distance > 0.0f)
                {

                }

                AxleInstance.Position = endPosition;
                AxleInstance.Z += 1f;
            }
        }

        private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
