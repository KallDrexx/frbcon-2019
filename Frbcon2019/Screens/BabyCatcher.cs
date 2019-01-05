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
using Frbcon2019.Factories;

namespace Frbcon2019.Screens
{
	public partial class BabyCatcher
	{
        double lastBabySpawn = 0.0f;
		void CustomInitialize()
		{
            // Immediately trigger the spawn to spawn.
            lastBabySpawn = TimeManager.CurrentTime - BabySpawnTimerSeconds;
		}

		void CustomActivity(bool firstTimeCalled)
		{
            if (GameIsActive && BabyList.Count < MaxBabies)
            {
                var secondsSinceLastBaby = TimeManager.SecondsSince(lastBabySpawn);

                if (secondsSinceLastBaby >= BabySpawnTimerSeconds)
                {
                    // Happy Birthday!
                    var baby = BabyFactory.CreateNew(0, 300);

                    // Baby: WEEEEEE!!!!
                    baby.YAcceleration = -Gravity;
                    baby.XVelocity = FlatRedBallServices.Random.Between(-MaxBabySpeedX, MaxBabySpeedX);
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
