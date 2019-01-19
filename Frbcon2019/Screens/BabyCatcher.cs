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
using Microsoft.Xna.Framework;
using Frbcon2019.Entities.BabyCatcher;
using FlatRedBall.Gui;

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

            if (GameIsActive)
            {
                if (BabyList.Count < MaxBabies)
                {
                    var secondsSinceLastBaby = TimeManager.SecondsSince(lastBabySpawn);

                    if (secondsSinceLastBaby >= BabySpawnTimerSeconds)
                    {
                        var portal = BabyPortalList[FlatRedBallServices.Random.Next(BabyPortalList.Count)];

                        portal.SpawnBaby();


                    }
                }

                LerpCatcherPosition();

                for (int x = BabyList.Count - 1; x >= 0; --x)
                {
                    var baby = BabyList[x];
                    if (baby.CollideAgainstBounce(GroundFloor, 0, 1, .2f))
                    {
                        if (++baby.NumBounces > 2)
                        {
                            baby.Velocity = Vector3.Zero;
                            baby.RotationZVelocity = 0;
                        }
                    }

                    if (baby.CollideAgainst(CatcherOfBabiesInstance))
                    {
                        baby.Destroy();
                    }
                }
            }

            

		}

        const float maxLerpSeconds = .04f;
        private void LerpCatcherPosition()
        {
            var thisLerp = 1.0f / maxLerpSeconds * TimeManager.SecondDifference;
            var endPosition = new Vector3(GuiManager.Cursor.WorldXAt(0), GuiManager.Cursor.WorldYAt(0), 0);


            var distance = Vector3.Distance(CatcherOfBabiesInstance.Position, endPosition);


            if (distance > .0001f)
            {
                CatcherOfBabiesInstance.Position = Vector3.Lerp(CatcherOfBabiesInstance.Position, endPosition, thisLerp);

                CatcherOfBabiesInstance.RotationZ = .015f * (CatcherOfBabiesInstance.X - endPosition.X);
            }
            else
            {
                if (distance > 0.0f)
                {

                }

                CatcherOfBabiesInstance.RotationZ = 0f;
                CatcherOfBabiesInstance.Position = endPosition;
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
