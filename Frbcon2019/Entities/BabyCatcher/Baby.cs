
using FlatRedBall;
using Microsoft.Xna.Framework;

namespace Frbcon2019.Entities.BabyCatcher
{
	public partial class Baby
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
        {
            var endPosition = this.BodySpriteInstance.Position;
            endPosition += this.BodySpriteInstance.RotationMatrix.Up * 20;
            endPosition.Z = BodySpriteInstance.Z + 1;

            HeadSpriteInstance.Position = endPosition;

            HeadSpriteInstance.ForceUpdateDependencies();

        }

        const float maxLerpSeconds = .033f;
        
		private void CustomActivity()
        {
            
            var thisLerp = 1 / maxLerpSeconds * TimeManager.SecondDifference;

            var endPosition = this.Position;
            endPosition += this.RotationMatrix.Up * 20;
            var distance = Vector3.Distance(HeadSpriteInstance.Position, endPosition);


            if (distance > .0001f)
            {
                HeadSpriteInstance.Position = Vector3.Lerp(HeadSpriteInstance.Position, endPosition, thisLerp);

                HeadSpriteInstance.ForceUpdateDependencies();
            }
            else
            {
                if (distance > 0.0f)
                {

                }

                HeadSpriteInstance.Position = endPosition;
                HeadSpriteInstance.Z += 1f;
            }
            

            //maxDistance = Math.Max(distance, maxDistance);
            
           
            //var headposition = Vector3.Lerp(HeadSpriteInstance.Position, endPosition, ((float)tweenFrame) / ((float)maxTweenFrames));
            //HeadSpriteInstance.Position = headposition;
           
            
            //if (tweenFrame >= maxTweenFrames)
            //{
            //    tweenFrame = maxTweenFrames;
            //}


            //HeadSpriteInstance.Position =  endPosition;

            
        }

		private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
