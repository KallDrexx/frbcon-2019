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
using static Frbcon2019.Entities.BabyCatcher.Baby;
using Microsoft.Xna.Framework;

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
            baby.HeadSpriteInstance.Position = this.Position;
            baby.HeadSpriteInstance.Z += 1;
            baby.HeadSpriteInstance.RelativeRotationZ = MathHelper.ToRadians(FlatRedBallServices.Random.Next(-15, 15));

            // Baby: WEEEEEE!!!!
            baby.YAcceleration = -Gravity;
            baby.YVelocity = -Gravity * .25f;
            baby.XVelocity = FlatRedBallServices.Random.Between(-MaxBabySpeedX, MaxBabySpeedX);
            //baby.RotationZVelocity = FlatRedBallServices.Random.Between(-MaxBabyRotationZVelocity, MaxBabyRotationZVelocity);
            //baby.RotationZ += baby.RotationZVelocity;

            var colors = new[] { ColorState.Blue, ColorState.Green, ColorState.Lightblue, ColorState.Orange, ColorState.OtherGreen, ColorState.Pink, ColorState.Purple, ColorState.Yellow };

            var heads = new[] { BabyHead.BaldBow, BabyHead.IrritatedSpeckle, BabyHead.Jerkface, BabyHead.Pacifier, BabyHead.SurprisePeanut, BabyHead.UnsureHazelnut };


            baby.CurrentColorStateState = (ColorState)colors.GetValue(FlatRedBallServices.Random.Next(colors.Length));
            baby.CurrentBabyHeadState = (BabyHead)heads.GetValue(FlatRedBallServices.Random.Next(heads.Length));
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