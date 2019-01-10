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
using Frbcon2019.Factories;

namespace Frbcon2019.Entities.BabyCatcher
{
	public partial class BabyPortal
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        void CustomInitialize()
        {
        }

        public void SpawnBaby()
        {
            // Happy Birthday!
            var baby = BabyFactory.CreateNew();
            baby.Position = this.Position;
            baby.Y -= 15;

            baby.Z += 1;

            // Baby: WEEEEEE!!!!
            baby.YAcceleration = -Gravity;
            baby.YVelocity = -Gravity * .25f;
            baby.XVelocity = FlatRedBallServices.Random.Between(-MaxBabySpeedX, MaxBabySpeedX);
            baby.RotationZVelocity = FlatRedBallServices.Random.Between(-MaxBabyRotationZVelocity, MaxBabyRotationZVelocity);
            baby.RotationZ += baby.RotationZVelocity;
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
