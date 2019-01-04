using System.Linq;
using FlatRedBall;
using FlatRedBall.Gui;
using FlatRedBall.Math.Collision;
using Frbcon2019.Entities.SpaceInvaders;
using Frbcon2019.Factories;

namespace Frbcon2019.Screens
{
	public partial class SpaceInvaders
	{
		protected override void GameStarted()
		{
			foreach (var alien in AlienList)
			{
				alien.XVelocity = AlienMovementSpeed;
			}
		}

		void CustomInitialize()
		{
			RightGuardRail.X = Camera.Main.AbsoluteRightXEdgeAt(0);
			LeftGuardRail.X = Camera.Main.AbsoluteLeftXEdgeAt(0);

			SpawnAliens();
		}

		void CustomActivity(bool firstTimeCalled)
		{
			if (!IsInGame) return;

			PlayerShipInstance.Y = PlayerYPosition;
			PlayerShipInstance.X = GuiManager.Cursor.WorldXAt(0);
			PlayerShipInstance.EnsureStillOnScreen();

			foreach (var bullet in BulletList)
			{
				if (!bullet.IsInView())
				{
					bullet.Destroy();
				}
			}

			if (!AlienList.Any())
			{
				TriggerWinCondition();
				return;
			}

			if (GuiManager.Cursor.PrimaryClick)
			{
				var bullet = BulletFactory.CreateNew();
				bullet.X = PlayerShipInstance.X;
				bullet.Y = PlayerShipInstance.Y;
				bullet.Z = PlayerShipInstance.Z - 1;

				bullet.YVelocity = BulletSpeed;

				CollisionManager.Self.CreateRelationship(bullet, AlienList)
					.CollisionOccurred = (bullet1, alien) =>
				{
					bullet.Destroy();
					alien.Destroy();
				};
			}
		}

		void CustomDestroy()
		{
			foreach (var alien in AlienList)
			{
				alien.Destroy();
			}
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }

        private void SpawnAliens()
        {
	        const int buffer = 100;

	        var minLeft = Camera.Main.AbsoluteLeftXEdgeAt(0) + buffer;

	        var(rowCount, columnCount) = GetAlienCounts();
	        for (var row = 0; row < rowCount; row++)
	        for (var column = 0; column < columnCount; column++)
	        {
		        var alien = new Alien
		        {
			        X = (column * (100 + 15)) + minLeft,
			        Y = AlienStartY - (row * (39 + 15))
		        };

		        AlienList.Add(alien);
	        }

	        CollisionManager.Self.CreateRelationship(AlienList, RightGuardRail)
		        .CollisionOccurred = (x, y) => HandleAlienGuideRailCollison(true);

	        CollisionManager.Self.CreateRelationship(AlienList, LeftGuardRail)
		        .CollisionOccurred = (x, y) => HandleAlienGuideRailCollison(false);
        }

        private void HandleAlienGuideRailCollison(bool wasRightGuardRail)
        {
	        var newVelocity = wasRightGuardRail ? -AlienMovementSpeed : AlienMovementSpeed;

	        foreach (var alien in AlienList)
	        {
		        alien.XVelocity = newVelocity;
		        alien.Y -= alien.SpriteInstanceHeight / 3;
	        }
        }

        private (int rows, int columns) GetAlienCounts()
        {
	        switch (CurrentDifficultyFactor)
	        {
		        case DifficultyFactor.Easy: return (1, 5);
		        case DifficultyFactor.Medium: return (2, 5);
		        case DifficultyFactor.Hard: return (3, 5);
		        case DifficultyFactor.ExtraHard:
			    default:
			        return (4, 5);
	        }
        }
	}
}
