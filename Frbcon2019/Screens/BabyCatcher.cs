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
            if (firstTimeCalled)
            {
                BirthdaySong.Play();
                this.Call(() => { BirthdaySong.Stop(); }).After(5.45);
            }

            if (GameIsActive && BabyList.Count < MaxBabies)
            {
                var secondsSinceLastBaby = TimeManager.SecondsSince(lastBabySpawn);

                if (secondsSinceLastBaby >= BabySpawnTimerSeconds)
                {
                    var portal = BabyPortalList[FlatRedBallServices.Random.Next(BabyPortalList.Count)];

                    portal.SpawnBaby();

                    
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
