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
using FlatRedBall.Math.Collision;
using Frbcon2019.GumRuntimes;

namespace Frbcon2019.Screens
{
	public partial class BabyCatcher
	{
        double lastBabySpawn = 0.0f;
        int babiesCaught = 0;
        
		void CustomInitialize()
		{
            // Immediately trigger the spawn to spawn.
            lastBabySpawn = TimeManager.CurrentTime - BabySpawnTimerSeconds;
            lastChuteChange = TimeManager.CurrentTime - ChuteDirectionChangeFrequencyMaxSeconds;

            FlatRedBallServices.GraphicsOptions.BackgroundColor = Color.FromNonPremultiplied(58, 47, 77, 255);
            FlatRedBallServices.Game.IsMouseVisible = false;

            babiesCaught = 0;
        }

        
		void CustomActivity(bool firstTimeCalled)
		{
            if (firstTimeCalled)
            {
                CatchMePleaseInstance.Play();
                CreateCollisions();
            }


            if (AudioManager.CurrentlyPlayingSong != LullabySong)
            {
                AudioManager.PlaySong(LullabySong, true, true);
            }

            if (GameIsActive)
            {
                if (InputManager.Keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.Space))
                {
                    CurrentChuteBehaviorState = CurrentChuteBehaviorState == ChuteBehavior.FullThrottle ? ChuteBehavior.Normal : ChuteBehavior.FullThrottle;
                }
                HandleBabySpawns();
                HandleBabyBoundaries();
                RotateBabies();
                LerpCatcherPosition();

                ChuteMovement();
                LerpChutePosition();
                UpdateBabyMeter();
            }
        }

        private void UpdateBabyMeter()
        {
            var meter = ((BabyCatcherGumRuntime)BabyCatcherGum.Element).BabyMeterInstance;

            meter.Percentage = (int)
                ((babiesCaught / (float)CatchGoal) * 100);
        }

        private void RotateBabies()
        {
            foreach (var baby in BabyList)
            {
                baby.RotationZVelocity = -baby.Velocity.X / baby.CircleInstance.Radius;
            }
        }

        private void HandleBabyBoundaries()
        {
            for (int i = BabyList.Count - 1; i >= 0; --i)
            {
                var baby = BabyList[i];

                if (baby.Left > 400 || baby.Right < -400 || baby.Top < -300 || baby.Bottom > 300)
                {
                    baby.Destroy();
                } 
            }
        }

        private void CreateCollisions()
        {
            CreateBabyCollisions();
            CreateTrashCollisions();
            
        }

        private void CreateTrashCollisions()
        {
            var trashlisttoSelf = CollisionManager.Self.CreateRelationship(TrashList, TrashList);
            trashlisttoSelf.SetBounceCollision(1, 1, .2f);

            CollisionManager.Self.CreateRelationship(TrashList, CatcherOfBabiesInstance).CollisionOccurred = (trash, catcher) => {
                trash.Destroy();
                CatcherOfBabiesInstance.PlayCatchAnimation();
                --babiesCaught;
            };

            var rel = CollisionManager.Self.CreateRelationship(TrashList, CatcherOfBabiesInstance);
            rel.SetSecondSubCollision(item => item.Bumpers);
            rel.SetBounceCollision(0, 1f, .5f);

            var trashFloorRel = CollisionManager.Self.CreateRelationship(TrashList, FloorShapes);
            trashFloorRel.SetBounceCollision(0, 1f, .2f);
            trashFloorRel.CollisionOccurred = (trash, floor) => {
                var secondsSinceLastPow = TimeManager.SecondsSince(lastPowPlayed);
                if (trash.NumBounces == 0 && secondsSinceLastPow >= SecondsPerPow)
                {
                    pow.Play();
                    lastPowPlayed = TimeManager.CurrentTime;
                }

                if (++trash.NumBounces > 2)
                {
                    trash.Velocity = Vector3.Zero;
                    trash.RotationZVelocity = 0;

                    trash.FadeAway();

                }

                if (trash.SpriteInstance.Alpha <= 0f)
                {
                    trash.Destroy();
                }
            };

        }
        ListVsListRelationship<Baby, Baby> babyListToSelf;
        private void CreateBabyCollisions()
        {
            babyListToSelf = CollisionManager.Self.CreateRelationship(BabyList, BabyList);

            babyListToSelf.SetBounceCollision(1, 1, .2f);
            

            babyListToSelf.CollisionOccurred = (baby1, baby2) =>
            {
                baby1.RotationZVelocity = 0;
                baby2.RotationZVelocity = 0;
            };

            CollisionManager.Self.Partition(BabyList, FlatRedBall.Math.Axis.X, 16f, true);

            CollisionManager.Self.CreateRelationship(BabyList, CatcherOfBabiesInstance).CollisionOccurred = (baby, catcher) =>
            {
                baby.Destroy();
                CatcherOfBabiesInstance.PlayCatchAnimation();
                ++babiesCaught;
            };

            var rel = CollisionManager.Self.CreateRelationship(BabyList, CatcherOfBabiesInstance.Bumpers);
            rel.SetBounceCollision(0, 1f, .6f);
            rel.CollisionOccurred = (baby, bumper) => {
                var secondsSinceLastPow = TimeManager.SecondsSince(lastPowPlayed);
                if (baby.NumBounces == 0 && baby.Velocity.Length() > (ChuteSpeed * .75f) && secondsSinceLastPow >= SecondsPerPow)
                {
                    pow.Play();
                    lastPowPlayed = TimeManager.CurrentTime;
                }
            };


            var babyFloorRel = CollisionManager.Self.CreateRelationship(BabyList, FloorShapes);

            babyFloorRel.SetBounceCollision(0, 1f, .2f);

            babyFloorRel.CollisionOccurred = (baby, floor) =>
            {
                

                if (++baby.NumBounces > 6)
                {
                    baby.Velocity = Vector3.Zero;
                    baby.RotationZVelocity = 0;

                    baby.FadeAway();

                }

                if (baby.HeadSpriteInstance.Alpha <= 0f)
                {
                    baby.Destroy();
                }
            };
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

        private void HandleBabySpawns()
        {
            var secondsSinceLastBaby = TimeManager.SecondsSince(lastBabySpawn);

            if (secondsSinceLastBaby >= BabySpawnTimerSeconds)
            {
                var roll = FlatRedBallServices.Random.Between(0f, 100f);

                if (roll <= TrashFrequencyPercent)
                {
                     Portal1.SpawnTrash();
                }

                for (int x = 0; x < BabiesPerSpawn; ++x)
                {
                    Portal1.SpawnBaby();
                }
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
            SpriteManager.RemovePositionedObject(chuteMover);
        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
