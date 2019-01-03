using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;

namespace Frbcon2019.Entities.ShooGame
{
	public partial class Mouse
	{
		public void ReactToBroomSweep(float sweepPositionX, float sweepPositionY)
		{
			var xDiff = Math.Abs(sweepPositionX - X);
			var yDiff = Math.Abs(sweepPositionY - Y);
			var distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
			if (distance <= DistanceAffected)
			{
				var angle = Math.Atan2(Y - sweepPositionY, X - sweepPositionX);
				var angularVelocity = MathFunctions.AngleToVector((float) angle) * MaxVelocity;
				Velocity = angularVelocity;
			}
		}

		public bool IsInView()
		{
			return SpriteInstance.Right > Camera.Main.AbsoluteLeftXEdgeAt(0) &&
			       SpriteInstance.Left < Camera.Main.AbsoluteRightXEdgeAt(0) &&
			       SpriteInstance.Top > Camera.Main.AbsoluteBottomYEdgeAt(0) &&
			       SpriteInstance.Bottom < Camera.Main.AbsoluteTopYEdgeAt(0);

		}

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
		}

		private void CustomActivity()
		{
		}

		private void CustomDestroy()
		{
		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {
        }
	}
}
