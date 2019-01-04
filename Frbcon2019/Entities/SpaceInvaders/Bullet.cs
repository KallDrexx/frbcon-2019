using FlatRedBall;

namespace Frbcon2019.Entities.SpaceInvaders
{
	public partial class Bullet
	{
		public bool IsInView()
		{
			return SpriteInstance.Right > Camera.Main.AbsoluteLeftXEdgeAt(Z) &&
			       SpriteInstance.Left < Camera.Main.AbsoluteRightXEdgeAt(Z) &&
			       SpriteInstance.Top > Camera.Main.AbsoluteBottomYEdgeAt(Z) &&
			       SpriteInstance.Bottom < Camera.Main.AbsoluteTopYEdgeAt(Z);

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
