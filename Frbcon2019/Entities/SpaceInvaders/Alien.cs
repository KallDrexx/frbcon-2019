using FlatRedBall;

namespace Frbcon2019.Entities.SpaceInvaders
{
	public partial class Alien
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
        {
	        var spriteColumn = FlatRedBallServices.Random.Next(0, SpriteColumns);
	        var spriteRows = FlatRedBallServices.Random.Next(0, SpriteRows);

	        SpriteInstance.LeftTexturePixel = spriteColumn * SpriteInstance.RightTexturePixel;
	        SpriteInstance.RightTexturePixel = (spriteColumn + 1) * SpriteInstance.RightTexturePixel;
	        SpriteInstance.TopTexturePixel = spriteRows * SpriteInstance.BottomTexturePixel;
	        SpriteInstance.BottomTexturePixel = (spriteRows + 1) * SpriteInstance.BottomTexturePixel;
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
