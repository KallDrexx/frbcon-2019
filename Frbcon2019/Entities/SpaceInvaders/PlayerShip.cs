

using FlatRedBall;

namespace Frbcon2019.Entities.SpaceInvaders
{
	public partial class PlayerShip
	{
		public void EnsureStillOnScreen()
		{
			if (SpriteInstance.Left < Camera.Main.AbsoluteLeftXEdgeAt(0))
			{
				X = Camera.Main.AbsoluteLeftXEdgeAt(0) + (SpriteInstance.Width / 2);
			}

			if (SpriteInstance.Right > Camera.Main.AbsoluteRightXEdgeAt(0))
			{
				X = Camera.Main.AbsoluteRightXEdgeAt(0) - (SpriteInstance.Width / 2);
			}
		}

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
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
