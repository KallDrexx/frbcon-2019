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
using static Frbcon2019.Entities.BabyCatcher.PowerUp;

namespace Frbcon2019.Screens
{
    public partial class BabyCatcher
    {
        double lastBabySpawn = 0.0f;
        int babiesCaught = 0;
        float trashTimeLeft = 0f;

        void CustomInitialize()
        {
            // Immediately trigger the spawn to spawn.
            lastBabySpawn = TimeManager.CurrentTime - BabySpawnTimerSeconds;
            lastChuteChange = TimeManager.CurrentTime - ChuteDirectionChangeFrequencyMaxSeconds;

            FlatRedBallServices.GraphicsOptions.BackgroundColor = Color.FromNonPremultiplied(58, 47, 77, 255);
            FlatRedBallServices.Game.IsMouseVisible = false;

            babiesCaught = 0;
            trashTimeLeft = 0f;
            CurrentChuteItemTypeState = ChuteItemType.Babies;
            nextTrash = PauseAdjustedCurrentTime + FlatRedBallServices.Random.Between(TrashFrequencyMinSeconds, TrashFrequencyMaxSeconds);
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

                SmokeActivity();
                PowerupActivity();
                HandleChuteSpawning();
                HandleBoundaries();
                SpawnExclamationPoints();
                RotateItems();
                LerpCatcherPosition();
                

                ChuteMovement();
                LerpChutePosition();
                UpdateBabyMeter();
            }
        }

        private void SpawnExclamationPoints()
        {
            foreach(var baby in BabyList)
            {
                if (baby.HeadSpriteInstance.Alpha <= .5f && !baby.ShowedExclamation)
                {
                    baby.ShowedExclamation = true;
                    var exclamation = ExclamationPointFactory.CreateNew(baby.X, baby.Y + 50f);
                    exclamation.Z = 10f;

                    exclamation.YVelocity = 100f;
                    exclamation.FadeAway();
                }
            }
        }

        private void SmokeActivity()
        {
            var smoke = Portal1.ThrowSmoke();

            smoke.FadeAway();
        }

        double nextPowerup = double.MinValue;

        private void PowerupActivity()
        {
            if (this.PauseAdjustedCurrentTime >= nextPowerup)
            {
                //                    CurrentChuteBehaviorState = CurrentChuteBehaviorState == ChuteBehavior.FullThrottle ? ChuteBehavior.Normal : ChuteBehavior.FullThrottle;

                //CurrentChuteItemTypeState = CurrentChuteItemTypeState == ChuteItemType.Babies ? ChuteItemType.Trash : ChuteItemType.Babies;

                SpawnRandomPowerup();
                nextPowerup = PauseAdjustedCurrentTime + FlatRedBallServices.Random.Between(PowerupFrequencySecondsMin, PowerupFrequencySecondsMax);
            }


            if (fullThrottleTimeLeft > 0f)
            {
                CurrentChuteBehaviorState = ChuteBehavior.FullThrottle;
            }
            else
            {
                CurrentChuteBehaviorState = ChuteBehavior.Normal;
            }

            var tick = (float)TimeManager.SecondsSince(TimeManager.LastCurrentTime);

            fullThrottleTimeLeft = Math.Max(fullThrottleTimeLeft - tick, 0f);


            if (bouncyTimeLeft > 0f)
            {
                babyBounceFactor = BouncePowerupElasticityMultiplier;
            }
            else
            {
                babyBounceFactor = 1f;
            }

            bouncyTimeLeft = Math.Max(bouncyTimeLeft - tick, 0f);


            if (bigHeadTimeLeft > 0f)
            {
                headScale = BigHeadPowerupScale;
            }
            else
            {
                headScale = .5f;
            }

            bigHeadTimeLeft = Math.Max(bigHeadTimeLeft - tick, 0f);
        }

        private void SpawnRandomPowerup()
        {
            int rand = FlatRedBallServices.Random.Next(1, 4);


            var x = FlatRedBallServices.Random.Between(-350f, 350f);

            var powerup = PowerUpFactory.CreateNew(x, 300);

            switch (rand)
            {
                case 1:
                    powerup.CurrentBottleTypeState = BottleType.BigHead;
                    break;
                case 2:
                    powerup.CurrentBottleTypeState = BottleType.Bouncy;
                    break;
                case 3:
                    powerup.CurrentBottleTypeState = BottleType.FullThrottle;
                    break;
            }

            powerup.Z = -2;
            powerup.YVelocity = -PowerupFallSpeed;
        }

        private void UpdateBabyMeter()
        {
            var meter = ((BabyCatcherGumRuntime)BabyCatcherGum.Element).BabyMeterInstance;
            var percentage = (int)
                ((babiesCaught / (float)CatchGoal) * 100);

            meter.Percentage = MathHelper.Clamp(percentage, 0, 100);


            if (meter.Percentage == 100)
            {
                TriggerWinCondition();
            }
        }

        private void RotateItems()
        {
            foreach (var baby in BabyList)
            {
                baby.RotationZVelocity = -baby.Velocity.X / (2.0f * baby.CircleInstance.Radius);
            }

            foreach (var trash in TrashList)
            {
                trash.RotationZVelocity = -trash.Velocity.X / (2.0f * trash.CircleInstance.Radius);
            }
        }

        private void HandleBoundaries()
        {
            for (int i = BabyList.Count - 1; i >= 0; --i)
            {
                var baby = BabyList[i];

                if (baby.Left > 400 || baby.Right < -400 || baby.Top < -300 || baby.Bottom > 300)
                {
                    baby.Destroy();
                }
            }

            for (int i = TrashList.Count - 1; i >= 0; --i)
            {
                var trash = TrashList[i];

                if (trash.Left > 400 || trash.Right < -400 || trash.Top < -300 || trash.Bottom > 300)
                {
                    trash.Destroy();
                }
            }
        }

        #region Collisions
        private void CreateCollisions()
        {
            CreateBabyCollisions();
            CreateTrashCollisions();
            CreatePowerupCollisions();
        }

        private void CreatePowerupCollisions()
        {
            var powerupsToCarriage = CollisionManager.Self.CreateRelationship(PowerUpList, CatcherOfBabiesInstance);
            powerupsToCarriage.SetEventOnlyCollision();
            powerupsToCarriage.CollisionOccurred = (powerup, catcher) => 
            {
                ApplyPowerup(powerup.CurrentBottleTypeState);
                powerup.Destroy();
                CatcherOfBabiesInstance.PlayCatchAnimation();
            };
        }

        float fullThrottleTimeLeft = 0f;
        float bouncyTimeLeft = 0f;
        float bigHeadTimeLeft = 0f;

        private void ApplyPowerup(BottleType state)
        {
            if (state == BottleType.BigHead)
            {
                bigHeadTimeLeft = BigHeadTime;
            }
            else if (state == BottleType.Bouncy)
            {
                bouncyTimeLeft = BouncyTime;
            }
            else if (state == BottleType.FullThrottle)
            {
                fullThrottleTimeLeft = FullThrottleTime;
            }
        }

        private void CreateTrashCollisions()
        {
            var trashlisttoSelf = CollisionManager.Self.CreateRelationship(TrashList, TrashList);
            trashlisttoSelf.SetBounceCollision(1, 1, .2f);

            CollisionManager.Self.CreateRelationship(TrashList, CatcherOfBabiesInstance).CollisionOccurred = (trash, catcher) =>
            {
                trash.Destroy();
                CatcherOfBabiesInstance.PlayCatchAnimation();
                --babiesCaught;
                babiesCaught = Math.Max(0, babiesCaught);
            };

            var rel = CollisionManager.Self.CreateRelationship(TrashList, CatcherOfBabiesInstance);
            rel.SetSecondSubCollision(item => item.Bumpers);
            rel.SetBounceCollision(0, 1f, .5f);

            var trashFloorRel = CollisionManager.Self.CreateRelationship(TrashList, FloorShapes);
            trashFloorRel.CollisionOccurred = (trash, floor) =>
            {
                var secondsSinceLastPow = TimeManager.SecondsSince(lastPowPlayed);
                trash.CollideAgainstBounce(floor, 0f, 1.0f, .2f);
                if (trash.NumBounces == 0)
                {
                    SpawnSmokePop(trash);
                }

                

                

                if (++trash.NumBounces > 2)
                {
                    trash.Drag = .5f;

                    trash.FadeAway();

                }

                if (trash.SpriteInstance.Alpha <= 0f)
                {
                    trash.Destroy();
                }
            };

        }

        private void CreateBabyCollisions()
        {
            var babyListToSelf = CollisionManager.Self.CreateRelationship(BabyList, BabyList);

            babyListToSelf.CollisionOccurred = (baby1, baby2) =>
            {
                baby1.CollideAgainstBounce(baby2, 1.0f, 1.0f, .2f * babyBounceFactor);
                baby1.RotationZVelocity = 0;
                baby2.RotationZVelocity = 0;
            };

            CollisionManager.Self.Partition(BabyList, FlatRedBall.Math.Axis.X, 16f, true);

            CollisionManager.Self.CreateRelationship(BabyList, CatcherOfBabiesInstance).CollisionOccurred = (baby, catcher) =>
            {
                baby.Destroy();
                CatcherOfBabiesInstance.PlayCatchAnimation();

                // Babies with big heads are worth 2
                if (Math.Abs(baby.HeadSpriteInstance.TextureScale - BigHeadPowerupScale) <= 0.001f)
                {
                    babiesCaught += 2;
                }
                else
                {
                    ++babiesCaught;
                }
            };

            var rel = CollisionManager.Self.CreateRelationship(BabyList, CatcherOfBabiesInstance.Bumpers);

            rel.CollisionOccurred = (baby, bumper) =>
            {
                baby.CollideAgainstBounce(bumper, 0f, 1.0f, .3f * babyBounceFactor);
                var secondsSinceLastPow = TimeManager.SecondsSince(lastPowPlayed);
                if (baby.NumBounces == 0 && baby.Velocity.Length() > (ChuteSpeed * .85f) && secondsSinceLastPow >= SecondsPerPow)
                {
                    SpawnSmokePop(baby);
                    pow.Play();
                    lastPowPlayed = TimeManager.CurrentTime;
                }

                
            };


            var babyFloorRel = CollisionManager.Self.CreateRelationship(BabyList, FloorShapes);

            babyFloorRel.CollisionOccurred = (baby, floor) =>
            {

                baby.CollideAgainstBounce(floor, 0f, 1.0f, .2f * babyBounceFactor);


                if (baby.NumBounces == 0)
                {
                    SpawnSmokePop(baby);

                }
                
                if (++baby.NumBounces > 6)
                {
                    baby.Drag = 10f;

                    baby.FadeAway();
                }

                if (baby.HeadSpriteInstance.Alpha <= 0f)
                {
                    baby.Destroy();
                }
            };
        }

        private void SpawnSmokePop(PositionedObject spawner)
        {
            int numPops = FlatRedBallServices.Random.Next(4) + 1;

            for (int i = 0; i < numPops; i++)
            {
                var smoke = SmokeParticle.CreateRandomSmokeParticle(spawner.X, spawner.Y);
                smoke.Velocity = new Vector3(FlatRedBallServices.Random.RadialVector2(400, 500), 0f);
                smoke.Drag = 10f;
                smoke.Z = 10f;
            }
        }
        #endregion


        #region Chute Movement
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

        #endregion


        private void HandleChuteSpawning()
        {
            if (trashTimeLeft > 0f)
            {
                var tick = (float)TimeManager.SecondsSince(TimeManager.LastCurrentTime);
                trashTimeLeft = Math.Max(0f, trashTimeLeft - tick);

                CurrentChuteItemTypeState = ChuteItemType.Trash;
            }
            else if (CurrentChuteItemTypeState == ChuteItemType.Trash)
            {
                CurrentChuteItemTypeState = ChuteItemType.Babies;
                nextTrash = PauseAdjustedCurrentTime + FlatRedBallServices.Random.Between(TrashFrequencyMinSeconds, TrashFrequencyMaxSeconds);
            }

            // If trash is supposed to fire
            if (CurrentChuteItemTypeState == ChuteItemType.Babies && PauseAdjustedCurrentTime >= nextTrash)
            {
                trashTimeLeft = FlatRedBallServices.Random.Between(TrashOnMinSeconds, TrashOnMaxSeconds);
            }

            var secondsSinceLastBaby = TimeManager.SecondsSince(lastBabySpawn);

            if (secondsSinceLastBaby >= BabySpawnTimerSeconds)
            {
                lastBabySpawn = TimeManager.CurrentTime;

                for (int x = 0; x < BabiesPerSpawn; ++x)
                {
                    if (CurrentChuteItemTypeState == ChuteItemType.Trash)
                    {
                        Portal1.SpawnTrash();
                    }
                    else
                    {
                        var baby = Portal1.SpawnBaby();

                        if (bigHeadTimeLeft > 0f)
                        {
                            baby.HeadSpriteInstance.TextureScale = BigHeadPowerupScale;
                        }
                    }
                }
            }
        }

        const float maxLerpSeconds = .04f;
        private float babyBounceFactor;
        private float headScale;
        private double nextTrash;

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
