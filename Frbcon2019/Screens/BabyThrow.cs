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
using Frbcon2019.Factories;
using Frbcon2019.Entities.BabyCatcher;
using static Frbcon2019.Entities.BabyCatcher.Baby;
using Microsoft.Xna.Framework;

namespace Frbcon2019.Screens
{
	public partial class BabyThrow
	{
        Baby CursorBaby;
		void CustomInitialize()
		{
            CursorBaby = Spawn();
		}

        private Baby Spawn()
        {
            var baby = BabyFactory.CreateNew(GuiManager.Cursor.WorldXAt(0), GuiManager.Cursor.WorldYAt(0));

            var colors = new[] { ColorState.Blue, ColorState.Green, ColorState.Lightblue, ColorState.Orange, ColorState.OtherGreen, ColorState.Pink, ColorState.Purple, ColorState.Yellow };

            var heads = new[] { BabyHead.BaldBow, BabyHead.IrritatedSpeckle, BabyHead.Jerkface, BabyHead.Pacifier, BabyHead.SurprisePeanut, BabyHead.UnsureHazelnut };


            baby.CurrentColorStateState = (ColorState)colors.GetValue(FlatRedBallServices.Random.Next(colors.Length));
            baby.CurrentBabyHeadState = (BabyHead)heads.GetValue(FlatRedBallServices.Random.Next(heads.Length));
            baby.HeadSpriteInstance.Position = baby.Position;
            baby.HeadSpriteInstance.Z += 1;
            baby.HeadSpriteInstance.RelativeRotationZ = MathHelper.ToRadians(FlatRedBallServices.Random.Next(-15, 15));

            return baby;
        }

        void CustomActivity(bool firstTimeCalled)
		{
            CursorBaby.XVelocity = GuiManager.Cursor.ActualXVelocityAt(0);
            CursorBaby.YVelocity = GuiManager.Cursor.ActualYVelocityAt(0);

            if (GuiManager.Cursor.PrimaryButton.IsDown)
            {
                CursorBaby.RotationZ += .01f;
            }

            if (GuiManager.Cursor.SecondaryButton.IsDown)
            {
                CursorBaby.RotationZ -= .01f;
            }

            if (GuiManager.Cursor.MiddleClick)
            {
                CursorBaby.YAcceleration = -5000.0f;
                CursorBaby.Velocity = Vector3.Up * 1000f;
            
                CursorBaby = Spawn();
            }

            FlatRedBallServices.Game.IsMouseVisible = false;

		}

		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
