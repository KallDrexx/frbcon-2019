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
	public partial class SmokeParticle
	{
        private bool fading;
        private double timeToDie;

        public static SmokeType[] SmokeTypes { get; } = new[] { SmokeType.Smoke1, SmokeType.Smoke2, SmokeType.Smoke3, SmokeType.Smoke4, SmokeType.Smoke5 };

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        private void CustomInitialize()
		{
            fading = false;
            timeToDie = double.MaxValue;
		}

        public static SmokeParticle CreateRandomSmokeParticle(float x, float y)
        {
            var smoke = SmokeParticleFactory.CreateNew(x, y);

            smoke.CurrentSmokeTypeState = (SmokeType)SmokeTypes.GetValue(FlatRedBallServices.Random.Next(SmokeTypes.Length));

            return smoke;
        }

		private void CustomActivity()
		{
            if (SpriteInstance.Alpha <= .01f || TimeManager.CurrentTime >= timeToDie || Velocity.Length() <= 100f)
            {
                this.Destroy();
            }

            if (fading)
            {
                SpriteInstance.Alpha *= .8f;
            }

            
        }

		private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        public void FadeAway()
        {
            this.fading = true;
        }

        public void DestroyAfter(double seconds)
        {
            this.timeToDie = TimeManager.CurrentTime + seconds;
        }
	}
}
