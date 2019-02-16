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
using Microsoft.Xna.Framework;
using static Frbcon2019.Entities.BabyCatcher.Baby;
using static Frbcon2019.Entities.BabyCatcher.Trash;

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

        public void SpawnTrash()
        {
            var trash = TrashFactory.CreateNew();
            trash.Position = this.SpawnRectangle.Position;
            trash.X = FlatRedBallServices.Random.Between(SpawnRectangle.Left, SpawnRectangle.Right);
            trash.Z = -3f;

            trash.YAcceleration = -Gravity;
            trash.Velocity = ChuteFireForce * this.RotationMatrix.Down;

            trash.StartBlinking();

            var trashTypes = new[] { TrashType.BowlingBall, TrashType.Horn, TrashType.Iron, TrashType.Sneaker };

            trash.CurrentTrashTypeState = (TrashType)trashTypes.GetValue(FlatRedBallServices.Random.Next(trashTypes.Length));
        }

        public void SpawnBaby()
        {
            // Happy Birthday!
            var baby = BabyFactory.CreateNew();
            baby.Position = this.SpawnRectangle.Position;
            baby.X = FlatRedBallServices.Random.Between(SpawnRectangle.Left, SpawnRectangle.Right);
            baby.Position.Z = -3f;
            baby.HeadSpriteInstance.Position = baby.Position;
            baby.HeadSpriteInstance.Z += 1;
            baby.HeadSpriteInstance.RelativeRotationZ = MathHelper.ToRadians(FlatRedBallServices.Random.Next(-MaxDegreesHeadTilt, MaxDegreesHeadTilt));

            // Baby: WEEEEEE!!!!
            baby.YAcceleration = -Gravity;
            baby.Velocity = ChuteFireForce * this.RotationMatrix.Down;

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
