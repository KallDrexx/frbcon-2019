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
using FlatRedBall.Audio;

namespace Frbcon2019.Screens
{
	public partial class BabyCatcher
	{
        double lastBabySpawn = 0.0f;
        
		void CustomInitialize()
		{
            // Immediately trigger the spawn to spawn.
            lastBabySpawn = TimeManager.CurrentTime - BabySpawnTimerSeconds;
            lastChuteChange = TimeManager.CurrentTime - ChuteDirectionChangeFrequencyMaxSeconds;

            FlatRedBallServices.GraphicsOptions.BackgroundColor = Color.FromNonPremultiplied(58, 47, 77, 255);
            FlatRedBallServices.Game.IsMouseVisible = false;
        }

		void CustomActivity(bool firstTimeCalled)
		{
            if (firstTimeCalled)
            {
                CatchMePleaseInstance.Play();                
            }

            if (AudioManager.CurrentlyPlayingSong != LullabySong)
            {
                AudioManager.PlaySong(LullabySong, true, true);
            }

            if (GameIsActive)
            {
                HandleBabySpawns();
                LerpCatcherPosition();
                HandleBabyActivity();

                ChuteMovement();
                LerpChutePosition();
            }



        }

        PositionedObject chuteMover = null;
        double lastChuteChange = 0.0f;
        double thisChuteMoveTimer = 0.0f;
        
        private void ChuteMovement()
        {
           
            if (chuteMover == null)
            {
                chuteMover = new PositionedObject()
                {
                    Position = Portal1.Position
                };

                SpriteManager.AddPositionedObject(chuteMover);
            }

            if (chuteMover.X < -400 || chuteMover.X > 400)
            {
                chuteMover.XAcceleration = 0;
                chuteMover.XVelocity = 0;
                lastChuteChange = 0;
            }

            chuteMover.X = MathHelper.Clamp(chuteMover.X, -400, 400);

            

            if (chuteMover.Y < ChuteMinY || chuteMover.Y > ChuteMaxY) 
            {
                chuteMover.YAcceleration = 0;
                chuteMover.YVelocity = 0;
                lastChuteChange = 0;
            }

            chuteMover.Y = MathHelper.Clamp(chuteMover.Y, ChuteMinY, ChuteMaxY);

            var secondsSinceLastChuteChange = TimeManager.SecondsSince(lastChuteChange);

            if (secondsSinceLastChuteChange >= thisChuteMoveTimer)
            {
                var n = new[] { -1, 1, .5f, -.5f, .75f, -.75f };


                chuteMover.XAcceleration = FlatRedBallServices.Random.In(n) * ChuteSpeed;
                chuteMover.YAcceleration = FlatRedBallServices.Random.In(n) * ChuteSpeed;

                thisChuteMoveTimer = FlatRedBallServices.Random.Between(ChuteDirectionChangeFrequencyMinSeconds, ChuteDirectionChangeFrequencyMaxSeconds);

                lastChuteChange = TimeManager.CurrentTime;
            }

            chuteMover.XVelocity = MathHelper.Clamp(chuteMover.XVelocity, -ChuteSpeed, ChuteSpeed);

        }

        const float maxChuteLerpSeconds = .08f;
        private void LerpChutePosition()
        {
            var thisLerp = 1.0f / maxChuteLerpSeconds * TimeManager.SecondDifference;
            var endPosition = chuteMover.Position;


            var distance = Vector3.Distance(Portal1.Position, endPosition);


            if (distance > .001f)
            {
                Portal1.Position = Vector3.Lerp(Portal1.Position, endPosition, thisLerp);

                Portal1.RotationZ = .015f * (Portal1.X - endPosition.X);
            }
            else
            {
                Portal1.RotationZ = 0f;
                Portal1.Position = endPosition;
            }
        }

        double lastPowPlayed = 0.0;


        private void HandleBabyActivity()
        {
            for (int x = BabyList.Count - 1; x >= 0; --x)
            {
                var baby = BabyList[x];
                if (baby.CollideAgainstBounce(GroundFloor, 0, 1, .2f))
                {
                    var secondsSinceLastPow = TimeManager.SecondsSince(lastPowPlayed);
                    if (baby.NumBounces == 0 && secondsSinceLastPow >= SecondsPerPow)
                    {
                        pow.Play();
                        lastPowPlayed = TimeManager.CurrentTime;
                    }

                    if (++baby.NumBounces > 2)
                    {
                        baby.Velocity = Vector3.Zero;
                        baby.RotationZVelocity = 0;

                        baby.FadeAway();

                    }

                    if (baby.HeadSpriteInstance.Alpha <= 0.0)
                    {
                        baby.Destroy();
                    }
                }


                if (baby.CollideAgainst(CatcherOfBabiesInstance))
                {
                    baby.Destroy();
                    CatcherOfBabiesInstance.PlayCatchAnimation();
                }

                if (baby.CollideAgainstBounce(CatcherOfBabiesInstance.Bumpers, 0, 1.0f, .5f))
                {
                    
                }
            }
        }

        private void HandleBabySpawns()
        {
            var secondsSinceLastBaby = TimeManager.SecondsSince(lastBabySpawn);

            if (secondsSinceLastBaby >= BabySpawnTimerSeconds)
            {
                var portal = BabyPortalList[FlatRedBallServices.Random.Next(BabyPortalList.Count)];

                portal.SpawnBaby();

                lastBabySpawn = TimeManager.CurrentTime;
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

            CatcherOfBabiesInstance.Y = MathHelper.Min(CatcherOfBabiesInstance.Y, MaxCatcherPositionY);
            CatcherOfBabiesInstance.Y = MathHelper.Max(CatcherOfBabiesInstance.Y, MinCatcherPositionY);
        }

        void CustomDestroy()
		{
            FlatRedBallServices.Game.IsMouseVisible = true;

        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
